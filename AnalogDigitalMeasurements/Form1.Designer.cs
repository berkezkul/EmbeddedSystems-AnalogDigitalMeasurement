
namespace UpdateKTS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menü = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_güncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.label_hata = new System.Windows.Forms.Label();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_basla = new System.Windows.Forms.Button();
            this.textBox_ktsNo = new System.Windows.Forms.TextBox();
            this.textBox_testiGerceklestiren = new System.Windows.Forms.TextBox();
            this.textBox_testNo = new System.Windows.Forms.TextBox();
            this.label_testiGerceklestiren = new System.Windows.Forms.Label();
            this.label_testNo = new System.Windows.Forms.Label();
            this.label_ktsSeriNo = new System.Windows.Forms.Label();
            this.dataGridView_kayıtlar = new System.Windows.Forms.DataGridView();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kayıtlar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menü
            // 
            this.panel_menü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel_menü.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menü.Location = new System.Drawing.Point(0, 0);
            this.panel_menü.Name = "panel_menü";
            this.panel_menü.Size = new System.Drawing.Size(224, 762);
            this.panel_menü.TabIndex = 1;
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(224, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1117, 100);
            this.panel_title.TabIndex = 2;
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_title.ForeColor = System.Drawing.Color.Navy;
            this.label_title.Location = new System.Drawing.Point(289, 26);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(403, 36);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "KONTROL TAHRİK SİSTEMİ";
            // 
            // button_güncelle
            // 
            this.button_güncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_güncelle.BackColor = System.Drawing.Color.Red;
            this.button_güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_güncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_güncelle.Location = new System.Drawing.Point(1160, 348);
            this.button_güncelle.Name = "button_güncelle";
            this.button_güncelle.Size = new System.Drawing.Size(130, 41);
            this.button_güncelle.TabIndex = 25;
            this.button_güncelle.Text = "Güncelle";
            this.button_güncelle.UseVisualStyleBackColor = false;
            this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sil.BackColor = System.Drawing.Color.Red;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_sil.Location = new System.Drawing.Point(1009, 348);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(119, 41);
            this.button_sil.TabIndex = 24;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // label_hata
            // 
            this.label_hata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_hata.AutoSize = true;
            this.label_hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hata.ForeColor = System.Drawing.Color.Red;
            this.label_hata.Location = new System.Drawing.Point(274, 378);
            this.label_hata.Name = "label_hata";
            this.label_hata.Size = new System.Drawing.Size(0, 20);
            this.label_hata.TabIndex = 23;
            // 
            // button_ekle
            // 
            this.button_ekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ekle.BackColor = System.Drawing.Color.Red;
            this.button_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_ekle.Location = new System.Drawing.Point(862, 348);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(119, 41);
            this.button_ekle.TabIndex = 22;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_basla
            // 
            this.button_basla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_basla.BackColor = System.Drawing.Color.LightCyan;
            this.button_basla.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button_basla.FlatAppearance.BorderSize = 2;
            this.button_basla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_basla.Location = new System.Drawing.Point(991, 219);
            this.button_basla.Name = "button_basla";
            this.button_basla.Size = new System.Drawing.Size(116, 45);
            this.button_basla.TabIndex = 21;
            this.button_basla.Text = "Başla";
            this.button_basla.UseVisualStyleBackColor = false;
            this.button_basla.Click += new System.EventHandler(this.button_basla_Click);
            // 
            // textBox_ktsNo
            // 
            this.textBox_ktsNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_ktsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ktsNo.Location = new System.Drawing.Point(633, 150);
            this.textBox_ktsNo.Name = "textBox_ktsNo";
            this.textBox_ktsNo.Size = new System.Drawing.Size(206, 34);
            this.textBox_ktsNo.TabIndex = 20;
            // 
            // textBox_testiGerceklestiren
            // 
            this.textBox_testiGerceklestiren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_testiGerceklestiren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_testiGerceklestiren.Location = new System.Drawing.Point(633, 297);
            this.textBox_testiGerceklestiren.Name = "textBox_testiGerceklestiren";
            this.textBox_testiGerceklestiren.Size = new System.Drawing.Size(206, 34);
            this.textBox_testiGerceklestiren.TabIndex = 19;
            // 
            // textBox_testNo
            // 
            this.textBox_testNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_testNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_testNo.Location = new System.Drawing.Point(633, 224);
            this.textBox_testNo.Name = "textBox_testNo";
            this.textBox_testNo.Size = new System.Drawing.Size(206, 34);
            this.textBox_testNo.TabIndex = 18;
            // 
            // label_testiGerceklestiren
            // 
            this.label_testiGerceklestiren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_testiGerceklestiren.AutoSize = true;
            this.label_testiGerceklestiren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_testiGerceklestiren.Location = new System.Drawing.Point(363, 297);
            this.label_testiGerceklestiren.Name = "label_testiGerceklestiren";
            this.label_testiGerceklestiren.Size = new System.Drawing.Size(236, 29);
            this.label_testiGerceklestiren.TabIndex = 17;
            this.label_testiGerceklestiren.Text = "Testi Gerçekleştiren:";
            // 
            // label_testNo
            // 
            this.label_testNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_testNo.AutoSize = true;
            this.label_testNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_testNo.Location = new System.Drawing.Point(363, 227);
            this.label_testNo.Name = "label_testNo";
            this.label_testNo.Size = new System.Drawing.Size(105, 29);
            this.label_testNo.TabIndex = 16;
            this.label_testNo.Text = "Test No:";
            // 
            // label_ktsSeriNo
            // 
            this.label_ktsSeriNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_ktsSeriNo.AutoSize = true;
            this.label_ktsSeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ktsSeriNo.Location = new System.Drawing.Point(363, 153);
            this.label_ktsSeriNo.Name = "label_ktsSeriNo";
            this.label_ktsSeriNo.Size = new System.Drawing.Size(155, 29);
            this.label_ktsSeriNo.TabIndex = 15;
            this.label_ktsSeriNo.Text = "KTS Seri No:";
            // 
            // dataGridView_kayıtlar
            // 
            this.dataGridView_kayıtlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_kayıtlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_kayıtlar.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_kayıtlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kayıtlar.Location = new System.Drawing.Point(341, 431);
            this.dataGridView_kayıtlar.Name = "dataGridView_kayıtlar";
            this.dataGridView_kayıtlar.RowHeadersWidth = 51;
            this.dataGridView_kayıtlar.RowTemplate.Height = 24;
            this.dataGridView_kayıtlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_kayıtlar.Size = new System.Drawing.Size(687, 302);
            this.dataGridView_kayıtlar.TabIndex = 26;
            this.dataGridView_kayıtlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kayıtlar_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 762);
            this.Controls.Add(this.dataGridView_kayıtlar);
            this.Controls.Add(this.button_güncelle);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.label_hata);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.button_basla);
            this.Controls.Add(this.textBox_ktsNo);
            this.Controls.Add(this.textBox_testiGerceklestiren);
            this.Controls.Add(this.textBox_testNo);
            this.Controls.Add(this.label_testiGerceklestiren);
            this.Controls.Add(this.label_testNo);
            this.Controls.Add(this.label_ktsSeriNo);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_menü);
            this.Name = "Form1";
            this.Text = "Kontrol Tahrik Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kayıtlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menü;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_güncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Label label_hata;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_basla;
        private System.Windows.Forms.TextBox textBox_ktsNo;
        private System.Windows.Forms.TextBox textBox_testiGerceklestiren;
        private System.Windows.Forms.TextBox textBox_testNo;
        private System.Windows.Forms.Label label_testiGerceklestiren;
        private System.Windows.Forms.Label label_testNo;
        private System.Windows.Forms.Label label_ktsSeriNo;
        private System.Windows.Forms.DataGridView dataGridView_kayıtlar;
    }
}

