
namespace UpdateKTS
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_analog = new System.Windows.Forms.GroupBox();
            this.chart_analog = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_kırmızı = new System.Windows.Forms.TextBox();
            this.textBox_mavi = new System.Windows.Forms.TextBox();
            this.textBox_okumaSıklıgı = new System.Windows.Forms.TextBox();
            this.label_okumaSıklıgı = new System.Windows.Forms.Label();
            this.label_analog = new System.Windows.Forms.Label();
            this.textBox_analog2 = new System.Windows.Forms.TextBox();
            this.textBox_analog = new System.Windows.Forms.TextBox();
            this.label_analog2 = new System.Windows.Forms.Label();
            this.button_analogDur = new System.Windows.Forms.Button();
            this.button_analogOku = new System.Windows.Forms.Button();
            this.groupBox_dijital = new System.Windows.Forms.GroupBox();
            this.button_anaSayfa = new System.Windows.Forms.Button();
            this.chart_dijital = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_dijital = new System.Windows.Forms.Label();
            this.textBox_dijital = new System.Windows.Forms.TextBox();
            this.button_dijitalOku = new System.Windows.Forms.Button();
            this.button_dijitalDur = new System.Windows.Forms.Button();
            this.label_dijitalChart = new System.Windows.Forms.Label();
            this.dataGridView_analogTable = new System.Windows.Forms.DataGridView();
            this.timer_analog = new System.Windows.Forms.Timer(this.components);
            this.timer_dijital = new System.Windows.Forms.Timer(this.components);
            this.timer_plotAnalog = new System.Windows.Forms.Timer(this.components);
            this.timer_plotDijital = new System.Windows.Forms.Timer(this.components);
            this.timer_analog2 = new System.Windows.Forms.Timer(this.components);
            this.timer_table = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_analog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_analog)).BeginInit();
            this.groupBox_dijital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_dijital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_analogTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_analog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_dijital, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_analogTable, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 1055);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // groupBox_analog
            // 
            this.groupBox_analog.BackColor = System.Drawing.Color.Azure;
            this.groupBox_analog.Controls.Add(this.chart_analog);
            this.groupBox_analog.Controls.Add(this.textBox_kırmızı);
            this.groupBox_analog.Controls.Add(this.textBox_mavi);
            this.groupBox_analog.Controls.Add(this.textBox_okumaSıklıgı);
            this.groupBox_analog.Controls.Add(this.label_okumaSıklıgı);
            this.groupBox_analog.Controls.Add(this.label_analog);
            this.groupBox_analog.Controls.Add(this.textBox_analog2);
            this.groupBox_analog.Controls.Add(this.textBox_analog);
            this.groupBox_analog.Controls.Add(this.label_analog2);
            this.groupBox_analog.Controls.Add(this.button_analogDur);
            this.groupBox_analog.Controls.Add(this.button_analogOku);
            this.groupBox_analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_analog.ForeColor = System.Drawing.Color.Navy;
            this.groupBox_analog.Location = new System.Drawing.Point(3, 3);
            this.groupBox_analog.Name = "groupBox_analog";
            this.groupBox_analog.Size = new System.Drawing.Size(591, 960);
            this.groupBox_analog.TabIndex = 20;
            this.groupBox_analog.TabStop = false;
            this.groupBox_analog.Text = "Analog Values";
            // 
            // chart_analog
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_analog.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_analog.Legends.Add(legend5);
            this.chart_analog.Location = new System.Drawing.Point(0, 531);
            this.chart_analog.Name = "chart_analog";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Navy;
            series7.Legend = "Legend1";
            series7.Name = "ai1";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "ai2";
            this.chart_analog.Series.Add(series7);
            this.chart_analog.Series.Add(series8);
            this.chart_analog.Size = new System.Drawing.Size(567, 326);
            this.chart_analog.TabIndex = 31;
            this.chart_analog.Text = "chart_analog";
            // 
            // textBox_kırmızı
            // 
            this.textBox_kırmızı.BackColor = System.Drawing.Color.Azure;
            this.textBox_kırmızı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_kırmızı.Location = new System.Drawing.Point(470, 275);
            this.textBox_kırmızı.Multiline = true;
            this.textBox_kırmızı.Name = "textBox_kırmızı";
            this.textBox_kırmızı.Size = new System.Drawing.Size(27, 29);
            this.textBox_kırmızı.TabIndex = 30;
            // 
            // textBox_mavi
            // 
            this.textBox_mavi.BackColor = System.Drawing.Color.Azure;
            this.textBox_mavi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mavi.Location = new System.Drawing.Point(470, 219);
            this.textBox_mavi.Multiline = true;
            this.textBox_mavi.Name = "textBox_mavi";
            this.textBox_mavi.Size = new System.Drawing.Size(29, 30);
            this.textBox_mavi.TabIndex = 29;
            // 
            // textBox_okumaSıklıgı
            // 
            this.textBox_okumaSıklıgı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_okumaSıklıgı.Location = new System.Drawing.Point(252, 69);
            this.textBox_okumaSıklıgı.Name = "textBox_okumaSıklıgı";
            this.textBox_okumaSıklıgı.Size = new System.Drawing.Size(207, 34);
            this.textBox_okumaSıklıgı.TabIndex = 28;
            this.textBox_okumaSıklıgı.TextChanged += new System.EventHandler(this.textBox_okumaSıklıgı_TextChanged);
            // 
            // label_okumaSıklıgı
            // 
            this.label_okumaSıklıgı.AutoSize = true;
            this.label_okumaSıklıgı.BackColor = System.Drawing.Color.Transparent;
            this.label_okumaSıklıgı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_okumaSıklıgı.ForeColor = System.Drawing.Color.Navy;
            this.label_okumaSıklıgı.Location = new System.Drawing.Point(-5, 72);
            this.label_okumaSıklıgı.Name = "label_okumaSıklıgı";
            this.label_okumaSıklıgı.Size = new System.Drawing.Size(261, 29);
            this.label_okumaSıklıgı.TabIndex = 27;
            this.label_okumaSıklıgı.Text = "Data reading frequency";
            this.label_okumaSıklıgı.Click += new System.EventHandler(this.label_okumaSıklıgı_Click);
            // 
            // label_analog
            // 
            this.label_analog.AutoSize = true;
            this.label_analog.BackColor = System.Drawing.Color.Transparent;
            this.label_analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_analog.ForeColor = System.Drawing.Color.Navy;
            this.label_analog.Location = new System.Drawing.Point(23, 258);
            this.label_analog.Name = "label_analog";
            this.label_analog.Size = new System.Drawing.Size(180, 29);
            this.label_analog.TabIndex = 19;
            this.label_analog.Text = "Analog Value 1:";
            // 
            // textBox_analog2
            // 
            this.textBox_analog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_analog2.Location = new System.Drawing.Point(252, 329);
            this.textBox_analog2.Name = "textBox_analog2";
            this.textBox_analog2.Size = new System.Drawing.Size(207, 34);
            this.textBox_analog2.TabIndex = 25;
            // 
            // textBox_analog
            // 
            this.textBox_analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_analog.Location = new System.Drawing.Point(252, 255);
            this.textBox_analog.Name = "textBox_analog";
            this.textBox_analog.Size = new System.Drawing.Size(207, 34);
            this.textBox_analog.TabIndex = 20;
            // 
            // label_analog2
            // 
            this.label_analog2.AutoSize = true;
            this.label_analog2.BackColor = System.Drawing.Color.Transparent;
            this.label_analog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_analog2.ForeColor = System.Drawing.Color.Navy;
            this.label_analog2.Location = new System.Drawing.Point(23, 332);
            this.label_analog2.Name = "label_analog2";
            this.label_analog2.Size = new System.Drawing.Size(180, 29);
            this.label_analog2.TabIndex = 24;
            this.label_analog2.Text = "Analog Value 2:";
            // 
            // button_analogDur
            // 
            this.button_analogDur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.button_analogDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_analogDur.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_analogDur.Location = new System.Drawing.Point(417, 403);
            this.button_analogDur.Name = "button_analogDur";
            this.button_analogDur.Size = new System.Drawing.Size(106, 48);
            this.button_analogDur.TabIndex = 22;
            this.button_analogDur.Text = "Durdur";
            this.button_analogDur.UseVisualStyleBackColor = false;
            this.button_analogDur.Click += new System.EventHandler(this.button_analogDur_Click);
            // 
            // button_analogOku
            // 
            this.button_analogOku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.button_analogOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_analogOku.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_analogOku.Location = new System.Drawing.Point(460, 170);
            this.button_analogOku.Name = "button_analogOku";
            this.button_analogOku.Size = new System.Drawing.Size(85, 43);
            this.button_analogOku.TabIndex = 21;
            this.button_analogOku.Text = "Oku";
            this.button_analogOku.UseVisualStyleBackColor = false;
            this.button_analogOku.Click += new System.EventHandler(this.button_analogOku_Click);
            // 
            // groupBox_dijital
            // 
            this.groupBox_dijital.BackColor = System.Drawing.Color.Azure;
            this.groupBox_dijital.Controls.Add(this.button_anaSayfa);
            this.groupBox_dijital.Controls.Add(this.chart_dijital);
            this.groupBox_dijital.Controls.Add(this.label_dijital);
            this.groupBox_dijital.Controls.Add(this.textBox_dijital);
            this.groupBox_dijital.Controls.Add(this.button_dijitalOku);
            this.groupBox_dijital.Controls.Add(this.button_dijitalDur);
            this.groupBox_dijital.Controls.Add(this.label_dijitalChart);
            this.groupBox_dijital.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_dijital.ForeColor = System.Drawing.Color.Navy;
            this.groupBox_dijital.Location = new System.Drawing.Point(1310, 3);
            this.groupBox_dijital.Name = "groupBox_dijital";
            this.groupBox_dijital.Size = new System.Drawing.Size(611, 960);
            this.groupBox_dijital.TabIndex = 19;
            this.groupBox_dijital.TabStop = false;
            this.groupBox_dijital.Text = "Digital Value";
            // 
            // button_anaSayfa
            // 
            this.button_anaSayfa.BackColor = System.Drawing.Color.DarkMagenta;
            this.button_anaSayfa.ForeColor = System.Drawing.Color.GhostWhite;
            this.button_anaSayfa.Location = new System.Drawing.Point(377, 869);
            this.button_anaSayfa.Name = "button_anaSayfa";
            this.button_anaSayfa.Size = new System.Drawing.Size(173, 52);
            this.button_anaSayfa.TabIndex = 33;
            this.button_anaSayfa.Text = "Ana Sayfa";
            this.button_anaSayfa.UseVisualStyleBackColor = false;
            this.button_anaSayfa.Click += new System.EventHandler(this.button_anaSayfa_Click);
            // 
            // chart_dijital
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_dijital.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_dijital.Legends.Add(legend6);
            this.chart_dijital.Location = new System.Drawing.Point(6, 306);
            this.chart_dijital.Name = "chart_dijital";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Navy;
            series9.Legend = "Legend1";
            series9.Name = "di1";
            this.chart_dijital.Series.Add(series9);
            this.chart_dijital.Size = new System.Drawing.Size(567, 326);
            this.chart_dijital.TabIndex = 32;
            this.chart_dijital.Text = "chart_dijital";
            // 
            // label_dijital
            // 
            this.label_dijital.AutoSize = true;
            this.label_dijital.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_dijital.ForeColor = System.Drawing.Color.Navy;
            this.label_dijital.Location = new System.Drawing.Point(11, 75);
            this.label_dijital.Name = "label_dijital";
            this.label_dijital.Size = new System.Drawing.Size(146, 29);
            this.label_dijital.TabIndex = 1;
            this.label_dijital.Text = "Dijital Value:";
            // 
            // textBox_dijital
            // 
            this.textBox_dijital.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_dijital.Location = new System.Drawing.Point(184, 72);
            this.textBox_dijital.Name = "textBox_dijital";
            this.textBox_dijital.Size = new System.Drawing.Size(207, 34);
            this.textBox_dijital.TabIndex = 3;
            // 
            // button_dijitalOku
            // 
            this.button_dijitalOku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.button_dijitalOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_dijitalOku.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_dijitalOku.Location = new System.Drawing.Point(344, 136);
            this.button_dijitalOku.Name = "button_dijitalOku";
            this.button_dijitalOku.Size = new System.Drawing.Size(94, 48);
            this.button_dijitalOku.TabIndex = 5;
            this.button_dijitalOku.Text = "Oku";
            this.button_dijitalOku.UseVisualStyleBackColor = false;
            this.button_dijitalOku.Click += new System.EventHandler(this.button_dijitalOku_Click);
            // 
            // button_dijitalDur
            // 
            this.button_dijitalDur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.button_dijitalDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_dijitalDur.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_dijitalDur.Location = new System.Drawing.Point(444, 136);
            this.button_dijitalDur.Name = "button_dijitalDur";
            this.button_dijitalDur.Size = new System.Drawing.Size(106, 48);
            this.button_dijitalDur.TabIndex = 7;
            this.button_dijitalDur.Text = "Durdur";
            this.button_dijitalDur.UseVisualStyleBackColor = false;
            this.button_dijitalDur.Click += new System.EventHandler(this.button_dijitalDur_Click);
            // 
            // label_dijitalChart
            // 
            this.label_dijitalChart.AutoSize = true;
            this.label_dijitalChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_dijitalChart.ForeColor = System.Drawing.Color.Navy;
            this.label_dijitalChart.Location = new System.Drawing.Point(6, 278);
            this.label_dijitalChart.Name = "label_dijitalChart";
            this.label_dijitalChart.Size = new System.Drawing.Size(196, 25);
            this.label_dijitalChart.TabIndex = 11;
            this.label_dijitalChart.Text = "Digital Value Change";
            // 
            // dataGridView_analogTable
            // 
            this.dataGridView_analogTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_analogTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_analogTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_analogTable.Location = new System.Drawing.Point(618, 3);
            this.dataGridView_analogTable.Name = "dataGridView_analogTable";
            this.dataGridView_analogTable.RowHeadersWidth = 51;
            this.dataGridView_analogTable.RowTemplate.Height = 24;
            this.dataGridView_analogTable.Size = new System.Drawing.Size(672, 960);
            this.dataGridView_analogTable.TabIndex = 15;
            this.dataGridView_analogTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_analogTable_CellContentClick);
            // 
            // timer_analog
            // 
            this.timer_analog.Tick += new System.EventHandler(this.timer_analog_Tick);
            // 
            // timer_dijital
            // 
            this.timer_dijital.Tick += new System.EventHandler(this.timer_dijital_Tick);
            // 
            // timer_plotAnalog
            // 
            this.timer_plotAnalog.Tick += new System.EventHandler(this.timer_plotAnalog_Tick);
            // 
            // timer_plotDijital
            // 
            this.timer_plotDijital.Tick += new System.EventHandler(this.timer_plotDijital_Tick);
            // 
            // timer_analog2
            // 
            this.timer_analog2.Tick += new System.EventHandler(this.timer_analog2_Tick);
            // 
            // timer_table
            // 
            this.timer_table.Tick += new System.EventHandler(this.timer_table_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Kontrol Tahrik Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_analog.ResumeLayout(false);
            this.groupBox_analog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_analog)).EndInit();
            this.groupBox_dijital.ResumeLayout(false);
            this.groupBox_dijital.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_dijital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_analogTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_analogTable;
        private System.Windows.Forms.GroupBox groupBox_dijital;
        private System.Windows.Forms.Label label_dijital;
        private System.Windows.Forms.TextBox textBox_dijital;
        private System.Windows.Forms.Button button_dijitalOku;
        private System.Windows.Forms.Button button_dijitalDur;
        private System.Windows.Forms.Label label_dijitalChart;
        private System.Windows.Forms.GroupBox groupBox_analog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_analog;
        private System.Windows.Forms.TextBox textBox_kırmızı;
        private System.Windows.Forms.TextBox textBox_mavi;
        private System.Windows.Forms.TextBox textBox_okumaSıklıgı;
        private System.Windows.Forms.Label label_okumaSıklıgı;
        private System.Windows.Forms.Label label_analog;
        private System.Windows.Forms.TextBox textBox_analog2;
        private System.Windows.Forms.TextBox textBox_analog;
        private System.Windows.Forms.Label label_analog2;
        private System.Windows.Forms.Button button_analogDur;
        private System.Windows.Forms.Button button_analogOku;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_dijital;
        private System.Windows.Forms.Timer timer_analog;
        private System.Windows.Forms.Timer timer_dijital;
        private System.Windows.Forms.Timer timer_plotAnalog;
        private System.Windows.Forms.Timer timer_plotDijital;
        private System.Windows.Forms.Timer timer_analog2;
        private System.Windows.Forms.Timer timer_table;
        private System.Windows.Forms.Button button_anaSayfa;
    }
}