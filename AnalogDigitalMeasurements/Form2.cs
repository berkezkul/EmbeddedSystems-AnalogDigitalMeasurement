using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;



namespace UpdateKTS
{
    public partial class Form2 : Form
    {

        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        private int excelRow = 2; // İlk satır başlık olduğu için 2'den başlatıyoruz

        private int interval = 1000; // Varsayılan veri okuma sıklığı
        private DateTime lastDataTime = DateTime.Now; // Son veri alma zamanı
        

        public Form2()
        {
            InitializeComponent();
            InitializeTimers();
        }


        private void InitializeTimers()
        {
            timer_analog = new Timer();
            timer_analog.Interval = 1000;
            timer_analog.Tick += timer_analog_Tick;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer_plotAnalog.Tick += timer_plotAnalog_Tick;
            groupBox_analog.Dock = DockStyle.Fill;
            groupBox_dijital.Dock = DockStyle.Fill;
            dataGridView_analogTable.Dock = DockStyle.Fill;
        }

        private void button_analogOku_Click(object sender, EventArgs e)
        {

            int interval;

            if (int.TryParse(textBox_okumaSıklıgı.Text, out interval) && interval > 0)
            {
                timer_analog.Interval = interval;
                timer_analog.Start();
                timer_analog2.Start();
                timer_plotAnalog.Start();
                timer_table.Start();

                dataGridView_analogTable.Columns.Add("Time", "Time");
                dataGridView_analogTable.Columns.Add("Voltage1", "Voltage 1");
                dataGridView_analogTable.Columns.Add("Voltage2", "Voltage 2");

                timer_table.Interval = interval;

                timer_table.Tick += timer_table_Tick;
                StartExcel();

                chart_analog.Series["ai1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_analog.Series["ai1"].BorderWidth = 2;

                chart_analog.Series["ai2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_analog.Series["ai2"].BorderWidth = 2;

                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = workbook.Sheets[1];

                // Başlık sütunlarını ekleyin
                worksheet.Cells[1, 1] = "Time";
                worksheet.Cells[1, 2] = "Voltage 1";
                worksheet.Cells[1, 3] = "Voltage 2";

                
                excelApp.Visible = true;


            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin ve 0'dan büyük olmalıdır.");
            }
        }

        private void StartExcel()
        {
            excelApp = new Excel.Application();
            workbook = excelApp.Workbooks.Add(Type.Missing);
            worksheet = workbook.Sheets[1];

            // Başlık sütunlarını ekleyin
            worksheet.Cells[1, 1] = "Time";
            worksheet.Cells[1, 2] = "Voltage 1";
            worksheet.Cells[1, 3] = "Voltage 2";

            // Excel uygulamasını görünür yapın
            excelApp.Visible = true;
        }

        private void timer_analog_Tick(object sender, EventArgs e)
        {
            NationalInstruments.DAQmx.Task analogInTask1 = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask1.AIChannels.CreateVoltageChannel(
                "Dev1/ai0",
                "myAIChannel",
                AITerminalConfiguration.Differential,
                0,
                1,
                AIVoltageUnits.Volts
                );
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask1.Stream);

            double voltage = reader.ReadSingleSample();
            textBox_analog.Text = voltage.ToString("N3");
            worksheet.Cells[excelRow, 2] = voltage.ToString("N3");

            interval = Convert.ToInt32(textBox_okumaSıklıgı.Text);

            // Excel'e ekleme zamanı geldiyse Excel'e veriyi ekle
            DateTime currentTime = DateTime.Now;
            if ((currentTime - lastDataTime).TotalMilliseconds >= interval)
            {
                lastDataTime = currentTime;
                string excelTime = currentTime.ToString("HH:mm:ss");
                worksheet.Cells[excelRow, 2] = voltage.ToString("N3");
                excelRow++;
            }
        }

        private void button_analogDur_Click(object sender, EventArgs e)
        {
            timer_analog.Stop();
            timer_analog2.Stop();
            timer_plotAnalog.Stop();
            timer_table.Stop();


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";

            // Masaüstü yolunu ve dosya adını ayarla
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss") + ".xlsx";
            string filePath = Path.Combine(desktopPath, fileName);

            workbook.SaveAs(filePath);
            MessageBox.Show("Veriler Excel'e kaydedildi.");

            /*
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Veriler Excel'e kaydedildi.");
            }
            */

            // Exceli kapat
            workbook.Close();
            excelApp.Quit();

            // Belleği temizle
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            MessageBox.Show("Veriler Excel'e kaydedildi ve DataGridView sıfırlandı.");
        }

        

        private void button_dijitalOku_Click(object sender, EventArgs e)
        {
            timer_dijital.Start();
            timer_plotDijital.Start();
        }

        private void timer_dijital_Tick(object sender, EventArgs e)
        {
            NationalInstruments.DAQmx.Task digitalInTask = new NationalInstruments.DAQmx.Task();
            DigitalSingleChannelReader reader;

            digitalInTask.DIChannels.CreateChannel(
                    "Dev1/port0/line3",
                    "myDIChannel",
                    ChannelLineGrouping.OneChannelForAllLines
                );

            reader = new DigitalSingleChannelReader(digitalInTask.Stream);

            bool[] digitalData = reader.ReadSingleSampleMultiLine();

            string result = string.Join(", ", digitalData.Select(d => d.ToString()));
            textBox_dijital.Text = result;
            digitalInTask.Dispose();
        }

        private void button_dijitalDur_Click(object sender, EventArgs e)
        {
            timer_dijital.Stop();
            timer_plotDijital.Stop();
        }



        private void timer_plotAnalog_Tick(object sender, EventArgs e)
        {
            float volt1, volt2;
            if (float.TryParse(textBox_analog.Text, out volt1) && float.TryParse(textBox_analog2.Text, out volt2))
            {
                chart_analog.Series["ai1"].Points.AddY(volt1);
                chart_analog.Series["ai2"].Points.AddY(volt2);
                chart_analog.ChartAreas[0].AxisX.Maximum = chart_analog.Series[0].Points.Count;
                chart_analog.ChartAreas[0].RecalculateAxesScale();
            }
            else
            {
                //MessageBox.Show("Geçerli bir sayı değil !");
            }
        }

        private void timer_plotDijital_Tick(object sender, EventArgs e)
        {
            bool digitalValue;
            if (bool.TryParse(textBox_dijital.Text, out digitalValue))
            {

                int yValue = digitalValue ? 1 : 0;
                chart_dijital.Series[0].Points.AddY(yValue);
                chart_dijital.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
                chart_dijital.ChartAreas[0].AxisX.Maximum = chart_dijital.Series[0].Points.Count;
                chart_dijital.ChartAreas[0].RecalculateAxesScale();

            }
            else
            {
                //MessageBox.Show("True ya da false değer tespit edilemedi !");
            }
        }

        private void timer_analog2_Tick(object sender, EventArgs e)
        {
          
            NationalInstruments.DAQmx.Task analogInTask2 = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel2;
            myAIChannel2 = analogInTask2.AIChannels.CreateVoltageChannel(
                "Dev1/ai1",
                "myAIChannel2",
                AITerminalConfiguration.Differential,
                0,
                1,
                AIVoltageUnits.Volts
            );
            AnalogSingleChannelReader reader2 = new AnalogSingleChannelReader(analogInTask2.Stream);

            
            double voltage2 = reader2.ReadSingleSample();
            textBox_analog2.Text = voltage2.ToString("N3");

            // Anlık veriyi Excel'e ekle
            interval = Convert.ToInt32(textBox_okumaSıklıgı.Text);
            DateTime currentTime = DateTime.Now;
            if ((currentTime - lastDataTime).TotalMilliseconds >= interval)
            {
                lastDataTime = currentTime;
                string excelTime = currentTime.ToString("HH:mm:ss");
                worksheet.Cells[excelRow, 1] = excelTime;
                worksheet.Cells[excelRow, 3] = voltage2.ToString("N3");
                excelRow++;
            }

            analogInTask2.Dispose();
            
        }

        private List<DataRow> dataRows = new List<DataRow>();
        private void timer_table_Tick(object sender, EventArgs e)
        {
            float volt1, volt2;
            if (float.TryParse(textBox_analog.Text, out volt1) && float.TryParse(textBox_analog2.Text, out volt2))
            {
                string time = DateTime.Now.ToString("HH:mm:ss");
                dataGridView_analogTable.Rows.Add(time, volt1, volt2);

                // Excel'e ekleme zamanı geldiğinde Excel'e veriyi ekle
                interval = Convert.ToInt32(textBox_okumaSıklıgı.Text);
                DateTime currentTime = DateTime.Now;
                if ((currentTime - lastDataTime).TotalMilliseconds >= interval)
                {
                    lastDataTime = currentTime;
                    string excelTime = currentTime.ToString("HH:mm:ss");
                    worksheet.Cells[excelRow, 1] = excelTime;
                    worksheet.Cells[excelRow, 2] = volt1.ToString("N3");
                    worksheet.Cells[excelRow, 3] = volt2.ToString("N3");
                    excelRow++;
                }
            }
            else
            {
                //MessageBox.Show("Hatalı karakter veya karakterler kullandınız. Bir sayı girerek tekrar deneyiniz !");
            }
        }

        private void button_anaSayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView_analogTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_okumaSıklıgı_TextChanged(object sender, EventArgs e)
        {

        }





        private void InitializeDigital(){
            try{// Dijital çıkış görevini oluşturun
                digitalOutTask = new NationalInstruments.DAQmx.Task();
                digitalOutTask.DOChannels.CreateChannel("Dev1/port0/line0", "", ChannelLineGrouping.OneChannelForAllLines);
                writer1 = new DigitalSingleChannelWriter(digitalOutTask.Stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public void TurnOnLed()
        {
            try{
                // LED'i açın (Dijital çıkışa "1" göndererek)
                if(writer1 != null)
                {
                    writer1.WriteSingleSampleSingleLine(true, true);
                }
            }
            catch (Exception ex)
            {
             MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public void TurnOffLed()
        {
            try
            {
                // LED'i kapatın (Dijital çıkışa "0" göndererek)
                if(writer1 != null)
                {
                    writer1.WriteSingleSampleSingleLine(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void textBox_dijital_TextChanged(object sender, EventArgs e)
        {
            if (textBox_dijital.Text == "True")
            {
                TurnOnLed();
            }
            else
            {
                TurnOffLed();
            }
        }


        
    }
}





