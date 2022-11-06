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
            this.pdfDosyaData = new System.Windows.Forms.DataGridView();
            this.TxtMaasData = new System.Windows.Forms.DataGridView();
            this.yuzdebar = new System.Windows.Forms.ProgressBar();
            this.OkumaLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExcelKaydet = new System.Windows.Forms.Button();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.btnTxtDosya = new System.Windows.Forms.Button();
            this.btnPdfDosyaSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pdfDosyaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaasData)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pdfDosyaData.Location = new System.Drawing.Point(13, 90);
            this.pdfDosyaData.Name = "pdfDosyaData";
            this.pdfDosyaData.RowHeadersWidth = 49;
            this.pdfDosyaData.RowTemplate.Height = 24;
            this.pdfDosyaData.Size = new System.Drawing.Size(1182, 209);
            this.pdfDosyaData.TabIndex = 1;
            this.pdfDosyaData.Visible = false;
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
            this.TxtMaasData.Location = new System.Drawing.Point(12, 323);
            this.TxtMaasData.Name = "TxtMaasData";
            this.TxtMaasData.RowHeadersWidth = 49;
            this.TxtMaasData.RowTemplate.Height = 24;
            this.TxtMaasData.Size = new System.Drawing.Size(1182, 189);
            this.TxtMaasData.TabIndex = 1;
            this.TxtMaasData.Visible = false;
            // 
            // yuzdebar
            // 
            this.yuzdebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yuzdebar.Location = new System.Drawing.Point(12, 518);
            this.yuzdebar.Name = "yuzdebar";
            this.yuzdebar.Size = new System.Drawing.Size(1184, 23);
            this.yuzdebar.TabIndex = 2;
            // 
            // OkumaLbl
            // 
            this.OkumaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkumaLbl.AutoSize = true;
            this.OkumaLbl.BackColor = System.Drawing.Color.DarkGreen;
            this.OkumaLbl.Location = new System.Drawing.Point(12, 522);
            this.OkumaLbl.Name = "OkumaLbl";
            this.OkumaLbl.Size = new System.Drawing.Size(0, 16);
            this.OkumaLbl.TabIndex = 3;
            this.OkumaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPdfDosyaSec);
            this.flowLayoutPanel1.Controls.Add(this.btnTxtDosya);
            this.flowLayoutPanel1.Controls.Add(this.btnKarsilastir);
            this.flowLayoutPanel1.Controls.Add(this.btnExcelKaydet);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1208, 70);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnExcelKaydet
            // 
            this.btnExcelKaydet.Image = global::OdemeKarsilatir.Properties.Resources.Excel_icon;
            this.btnExcelKaydet.Location = new System.Drawing.Point(588, 3);
            this.btnExcelKaydet.Name = "btnExcelKaydet";
            this.btnExcelKaydet.Size = new System.Drawing.Size(192, 56);
            this.btnExcelKaydet.TabIndex = 1;
            this.btnExcelKaydet.Text = "Excel Kaydet";
            this.btnExcelKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcelKaydet.UseVisualStyleBackColor = true;
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Image = global::OdemeKarsilatir.Properties.Resources.Compare_icon;
            this.btnKarsilastir.Location = new System.Drawing.Point(390, 3);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(192, 56);
            this.btnKarsilastir.TabIndex = 2;
            this.btnKarsilastir.Text = "Karşılaştır";
            this.btnKarsilastir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            // 
            // btnTxtDosya
            // 
            this.btnTxtDosya.Image = global::OdemeKarsilatir.Properties.Resources.txt_icon;
            this.btnTxtDosya.Location = new System.Drawing.Point(192, 3);
            this.btnTxtDosya.Name = "btnTxtDosya";
            this.btnTxtDosya.Size = new System.Drawing.Size(192, 56);
            this.btnTxtDosya.TabIndex = 3;
            this.btnTxtDosya.Text = "Maaş txt Dosyası";
            this.btnTxtDosya.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTxtDosya.UseVisualStyleBackColor = true;
            // 
            // btnPdfDosyaSec
            // 
            this.btnPdfDosyaSec.Image = global::OdemeKarsilatir.Properties.Resources.pdf_icon__1_;
            this.btnPdfDosyaSec.Location = new System.Drawing.Point(3, 3);
            this.btnPdfDosyaSec.Name = "btnPdfDosyaSec";
            this.btnPdfDosyaSec.Size = new System.Drawing.Size(183, 56);
            this.btnPdfDosyaSec.TabIndex = 4;
            this.btnPdfDosyaSec.Text = "Ödeme Pdf Dosyası";
            this.btnPdfDosyaSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPdfDosyaSec.UseVisualStyleBackColor = true;
            this.btnPdfDosyaSec.Click += new System.EventHandler(this.btnPdfDosyaSec_Click_1);
            // 
            // OdemeDosyasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 547);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.OkumaLbl);
            this.Controls.Add(this.yuzdebar);
            this.Controls.Add(this.TxtMaasData);
            this.Controls.Add(this.pdfDosyaData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdemeDosyasi";
            this.Text = "Ödeme Dosyalarını Karşılaştır";
            this.Load += new System.EventHandler(this.OdemeDosyasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfDosyaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaasData)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView pdfDosyaData;
        private System.Windows.Forms.DataGridView TxtMaasData;
        private System.Windows.Forms.ProgressBar yuzdebar;
        private System.Windows.Forms.Label OkumaLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExcelKaydet;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.Button btnTxtDosya;
        private System.Windows.Forms.Button btnPdfDosyaSec;
    }
}

