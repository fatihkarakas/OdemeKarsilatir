namespace OdemeKarsilatir
{
    partial class OdemeDosyasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeDosyasi));
            this.TxtMaasData = new System.Windows.Forms.DataGridView();
            this.yuzdebar = new System.Windows.Forms.ProgressBar();
            this.OkumaLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPdfDosyaSec = new System.Windows.Forms.Button();
            this.btnTxtDosya = new System.Windows.Forms.Button();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.btnExcelKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pdfDosyaData = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PdfTab = new System.Windows.Forms.TabPage();
            this.MaasTxtTab = new System.Windows.Forms.TabPage();
            this.KarsilastirmaTab = new System.Windows.Forms.TabPage();
            this.KarsilastirmaData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaasData)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfDosyaData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PdfTab.SuspendLayout();
            this.MaasTxtTab.SuspendLayout();
            this.KarsilastirmaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KarsilastirmaData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMaasData
            // 
            this.TxtMaasData.AllowUserToOrderColumns = true;
            this.TxtMaasData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMaasData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TxtMaasData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMaasData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtMaasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TxtMaasData.Location = new System.Drawing.Point(5, 2);
            this.TxtMaasData.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMaasData.Name = "TxtMaasData";
            this.TxtMaasData.RowHeadersWidth = 49;
            this.TxtMaasData.RowTemplate.Height = 24;
            this.TxtMaasData.Size = new System.Drawing.Size(1235, 423);
            this.TxtMaasData.TabIndex = 1;
            this.TxtMaasData.Visible = false;
            // 
            // yuzdebar
            // 
            this.yuzdebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yuzdebar.Location = new System.Drawing.Point(9, 566);
            this.yuzdebar.Margin = new System.Windows.Forms.Padding(2);
            this.yuzdebar.Name = "yuzdebar";
            this.yuzdebar.Size = new System.Drawing.Size(1237, 19);
            this.yuzdebar.TabIndex = 2;
            // 
            // OkumaLbl
            // 
            this.OkumaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkumaLbl.AutoSize = true;
            this.OkumaLbl.BackColor = System.Drawing.Color.DarkGreen;
            this.OkumaLbl.Location = new System.Drawing.Point(9, 569);
            this.OkumaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OkumaLbl.Name = "OkumaLbl";
            this.OkumaLbl.Size = new System.Drawing.Size(0, 13);
            this.OkumaLbl.TabIndex = 3;
            this.OkumaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPdfDosyaSec);
            this.flowLayoutPanel1.Controls.Add(this.btnTxtDosya);
            this.flowLayoutPanel1.Controls.Add(this.btnKarsilastir);
            this.flowLayoutPanel1.Controls.Add(this.btnExcelKaydet);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1255, 69);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnPdfDosyaSec
            // 
            this.btnPdfDosyaSec.Image = global::OdemeKarsilatir.Properties.Resources.pdf_icon__1_;
            this.btnPdfDosyaSec.Location = new System.Drawing.Point(2, 2);
            this.btnPdfDosyaSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdfDosyaSec.Name = "btnPdfDosyaSec";
            this.btnPdfDosyaSec.Size = new System.Drawing.Size(181, 57);
            this.btnPdfDosyaSec.TabIndex = 4;
            this.btnPdfDosyaSec.Text = "Ödeme Pdf Dosyası";
            this.btnPdfDosyaSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPdfDosyaSec.UseVisualStyleBackColor = true;
            this.btnPdfDosyaSec.Click += new System.EventHandler(this.btnPdfDosyaSec_Click_1);
            // 
            // btnTxtDosya
            // 
            this.btnTxtDosya.Image = global::OdemeKarsilatir.Properties.Resources.txt_icon;
            this.btnTxtDosya.Location = new System.Drawing.Point(187, 2);
            this.btnTxtDosya.Margin = new System.Windows.Forms.Padding(2);
            this.btnTxtDosya.Name = "btnTxtDosya";
            this.btnTxtDosya.Size = new System.Drawing.Size(144, 57);
            this.btnTxtDosya.TabIndex = 3;
            this.btnTxtDosya.Text = "Maaş txt Dosyası";
            this.btnTxtDosya.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTxtDosya.UseVisualStyleBackColor = true;
            this.btnTxtDosya.Click += new System.EventHandler(this.btnTxtDosya_Click);
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Image = global::OdemeKarsilatir.Properties.Resources.Compare_icon;
            this.btnKarsilastir.Location = new System.Drawing.Point(335, 2);
            this.btnKarsilastir.Margin = new System.Windows.Forms.Padding(2);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(144, 57);
            this.btnKarsilastir.TabIndex = 2;
            this.btnKarsilastir.Text = "Karşılaştır";
            this.btnKarsilastir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // btnExcelKaydet
            // 
            this.btnExcelKaydet.Image = global::OdemeKarsilatir.Properties.Resources.Excel_icon;
            this.btnExcelKaydet.Location = new System.Drawing.Point(483, 2);
            this.btnExcelKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelKaydet.Name = "btnExcelKaydet";
            this.btnExcelKaydet.Size = new System.Drawing.Size(144, 57);
            this.btnExcelKaydet.TabIndex = 1;
            this.btnExcelKaydet.Text = "Excel Kaydet";
            this.btnExcelKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcelKaydet.UseVisualStyleBackColor = true;
            this.btnExcelKaydet.Click += new System.EventHandler(this.btnExcelKaydet_Click);
            // 
            // button1
            // 
            this.button1.Image = global::OdemeKarsilatir.Properties.Resources.refreshh;
            this.button1.Location = new System.Drawing.Point(631, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yenile";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pdfDosyaData
            // 
            this.pdfDosyaData.AllowUserToOrderColumns = true;
            this.pdfDosyaData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfDosyaData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pdfDosyaData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.pdfDosyaData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdfDosyaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pdfDosyaData.Location = new System.Drawing.Point(2, 5);
            this.pdfDosyaData.Margin = new System.Windows.Forms.Padding(2);
            this.pdfDosyaData.Name = "pdfDosyaData";
            this.pdfDosyaData.RowHeadersWidth = 49;
            this.pdfDosyaData.RowTemplate.Height = 24;
            this.pdfDosyaData.Size = new System.Drawing.Size(1240, 446);
            this.pdfDosyaData.TabIndex = 1;
            this.pdfDosyaData.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PdfTab);
            this.tabControl1.Controls.Add(this.MaasTxtTab);
            this.tabControl1.Controls.Add(this.KarsilastirmaTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1255, 482);
            this.tabControl1.TabIndex = 5;
            // 
            // PdfTab
            // 
            this.PdfTab.Controls.Add(this.pdfDosyaData);
            this.PdfTab.Location = new System.Drawing.Point(4, 22);
            this.PdfTab.Name = "PdfTab";
            this.PdfTab.Padding = new System.Windows.Forms.Padding(3);
            this.PdfTab.Size = new System.Drawing.Size(1247, 456);
            this.PdfTab.TabIndex = 0;
            this.PdfTab.Text = "PDF Dosyasından Gelen";
            this.PdfTab.UseVisualStyleBackColor = true;
            // 
            // MaasTxtTab
            // 
            this.MaasTxtTab.Controls.Add(this.TxtMaasData);
            this.MaasTxtTab.Location = new System.Drawing.Point(4, 22);
            this.MaasTxtTab.Name = "MaasTxtTab";
            this.MaasTxtTab.Padding = new System.Windows.Forms.Padding(3);
            this.MaasTxtTab.Size = new System.Drawing.Size(1247, 456);
            this.MaasTxtTab.TabIndex = 1;
            this.MaasTxtTab.Text = "Maaş TXT Dosyasından Gelen";
            this.MaasTxtTab.UseVisualStyleBackColor = true;
            // 
            // KarsilastirmaTab
            // 
            this.KarsilastirmaTab.Controls.Add(this.KarsilastirmaData);
            this.KarsilastirmaTab.Location = new System.Drawing.Point(4, 22);
            this.KarsilastirmaTab.Name = "KarsilastirmaTab";
            this.KarsilastirmaTab.Padding = new System.Windows.Forms.Padding(3);
            this.KarsilastirmaTab.Size = new System.Drawing.Size(1247, 456);
            this.KarsilastirmaTab.TabIndex = 2;
            this.KarsilastirmaTab.Text = "Karşılaştırma Sonuçları";
            this.KarsilastirmaTab.UseVisualStyleBackColor = true;
            // 
            // KarsilastirmaData
            // 
            this.KarsilastirmaData.AllowUserToOrderColumns = true;
            this.KarsilastirmaData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KarsilastirmaData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KarsilastirmaData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.KarsilastirmaData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.KarsilastirmaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KarsilastirmaData.Location = new System.Drawing.Point(6, 5);
            this.KarsilastirmaData.Margin = new System.Windows.Forms.Padding(2);
            this.KarsilastirmaData.Name = "KarsilastirmaData";
            this.KarsilastirmaData.RowHeadersWidth = 49;
            this.KarsilastirmaData.RowTemplate.Height = 24;
            this.KarsilastirmaData.Size = new System.Drawing.Size(1235, 435);
            this.KarsilastirmaData.TabIndex = 2;
            this.KarsilastirmaData.Visible = false;
            // 
            // OdemeDosyasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 589);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.OkumaLbl);
            this.Controls.Add(this.yuzdebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OdemeDosyasi";
            this.Text = "BATI DSS Ödeme Dosyalarını Karşılaştır";
            this.Load += new System.EventHandler(this.OdemeDosyasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaasData)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfDosyaData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PdfTab.ResumeLayout(false);
            this.MaasTxtTab.ResumeLayout(false);
            this.KarsilastirmaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KarsilastirmaData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TxtMaasData;
        private System.Windows.Forms.ProgressBar yuzdebar;
        private System.Windows.Forms.Label OkumaLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExcelKaydet;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.Button btnTxtDosya;
        private System.Windows.Forms.Button btnPdfDosyaSec;
        private System.Windows.Forms.DataGridView pdfDosyaData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PdfTab;
        private System.Windows.Forms.TabPage MaasTxtTab;
        private System.Windows.Forms.TabPage KarsilastirmaTab;
        private System.Windows.Forms.DataGridView KarsilastirmaData;
        private System.Windows.Forms.Button button1;
    }
}

