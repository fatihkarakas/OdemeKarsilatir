using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace OdemeKarsilatir
{
    public partial class OdemeDosyasi : Form
    {
        public List<KisiOdeme> odemeListe = new List<KisiOdeme>();
        public List<txtSource> liste = new List<txtSource>();
        public List<KisiOdeme> txtOlmayanlar = new List<KisiOdeme>();
        public OdemeDosyasi()
        {
            InitializeComponent();
        }


        private void btnPdfDosyaSec_Click_1(object sender, EventArgs e)
        {
            odemeListe.Clear();
            string strText = string.Empty;
            List<string[]> st = new List<string[]>();

            OpenFileDialog ofd = new OpenFileDialog();
            string filepath;
            ofd.Filter = "PDF Files(*.PDF)|*.PDF|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filepath = ofd.FileName.ToString();
                PdfReader reader = new PdfReader(filepath);
                int intPageNum = reader.NumberOfPages;
                string[] words;
                string[] line1;
                try
                {
                    // PdfReader reader = new PdfReader(filepath);
                    yuzdebar.Minimum = 0;
                    yuzdebar.Maximum = intPageNum;
                    yuzdebar.Step = 1;

                    for (int page = 1; page <= intPageNum; page++)
                    {

                        yuzdebar.Value = page;
                        Cursor.Current = Cursors.WaitCursor;
                        Console.WriteLine(page);
                        ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                        var s = PdfTextExtractor.GetTextFromPage(reader, page);
                        words = s.Split('\n');

                        for (int i = 0; i < words.Length; i++)
                        {
                            line1 = words[i].Split(' ');
                            st.Add(line1);
                        }


                    }
                    foreach (string[] item in st)
                    {
                        string[] tutar = item[item.Length - 1].Split(',');

                        if (tutar.Length == 2 && item.Length >= 6)
                        {
                            string[] tutar1 = tutar[0].Split('.');
                            if (tutar1.Length > 1)
                            {
                                tutar[0] = tutar1[0] + tutar1[1] + ',' + tutar[1];
                            }
                            else
                            {
                                tutar[0] = tutar[0] + ',' + tutar[1];
                            }
                            Console.WriteLine(tutar[0]);
                            var kisi = new KisiOdeme()
                            {
                                Sira = Convert.ToInt32(item[0]),
                                tck = item[1],
                                adisoyadi = $"{item[2]} {item[3]}",
                                Iban = item[item.Length - 2],
                                Odeme = Convert.ToDecimal(tutar[0])

                            };
                            odemeListe.Add(kisi);
                        }

                    }
                    Cursor.Current = Cursors.Default;
                    pdfDosyaData.DataSource = odemeListe;
                    pdfDosyaData.Visible = true;
                    reader.Close();
                    OkumaLbl.Text = $"{filepath} dosyasındaki {intPageNum} kadar sayfa okundu. Toplam {odemeListe.Count} kayıt getirildi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show($"{filepath} dosyasındaki {intPageNum} kadar sayfa okundu. Toplam {odemeListe.Count} kayıt getirildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (pdfDosyaData.RowCount == 0)
                {
                    btnExcelKaydet.Enabled = false;
                    btnKarsilastir.Enabled = false;
                    btnTxtDosya.Enabled = false;
                }
                else
                {
                    btnTxtDosya.Enabled = true;
                }
            }

        }

        private void OdemeDosyasi_Load(object sender, EventArgs e)
        {
            btnExcelKaydet.Enabled = false;
            btnKarsilastir.Enabled = false;
            btnTxtDosya.Enabled = false;
        }

        private void btnTxtDosya_Click(object sender, EventArgs e)
        {
            liste.Clear();
            Cursor.Current = Cursors.WaitCursor;
            List<string> list = new List<string>();
            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    string adresPath = dosya.FileName;
                    list = File.ReadAllLines(adresPath, Encoding.GetEncoding("iso-8859-9")).ToList();

                    foreach (string item in list)
                    {
                        if (item.Substring(0, 2) == "DH")
                        {
                            txtSource txtSource = new txtSource()
                            {
                                kod = item.Substring(0, 2),
                                BankaKod = item.Substring(2, 7),
                                BankaSube = item.Substring(9, 8),
                                BankaHesapNo = item.Substring(17, 4),
                                Odenecek = Convert.ToDecimal(item.Substring(21, 18)),
                                Adi = item.Substring(39, 50).Trim(),
                                Soyadi = item.Substring(89, 50).Trim(),
                                Aciklama = item.Substring(139, 100),

                            };
                            if (item.Length == 265)
                            {
                                txtSource.Iban = item.Substring(239, 26);
                            }
                            liste.Add(txtSource);
                        }

                    }
                    decimal ToplamTutar = liste.Sum(x => x.Odenecek);
                    MessageBox.Show($"Toplam Ödenecek Tutar : {ToplamTutar}", "Bilgilendirme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtMaasData.DataSource = liste;
                    TxtMaasData.Visible = true;
                    OkumaLbl.Text = $"Toplam Ödenecek Tutar : {ToplamTutar}";
                    btnKarsilastir.Enabled = true;
                    btnTxtDosya.Enabled = true;
                    MessageBox.Show($"{adresPath} dosyasındaki txt verileri okundu . Toplam {liste.Count} kayıt getirildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata oluştu {ex.Message.ToString()}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            txtOlmayanlar.Clear();
            yuzdebar.Maximum = 100;
            int deger = 1;
            foreach (var item in odemeListe)
            {
                Cursor.Current = Cursors.WaitCursor;

                if (liste.FindAll(x => x.Iban.Contains(item.Iban)).Count == 0)
                {
                    txtOlmayanlar.Add(item);
                }
                if (liste.Where(x => x.Iban == item.Iban && x.Odenecek != item.Odeme).ToList().Count != 0)
                {
                    txtOlmayanlar.Add(item);
                }
                yuzdebar.Value = Convert.ToInt32((deger) * (100) / odemeListe.Count);
                deger++;
            }
            btnExcelKaydet.Enabled = true;
            KarsilastirmaData.DataSource = txtOlmayanlar;
            KarsilastirmaData.Visible = true;
            MessageBox.Show($"TXT ve PDF Dosyası Karşılaştırıldı . Toplam {txtOlmayanlar.Count} kadar IBAN'a kayıt txt içinde bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcelKaydet_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable xmlDt = new DataTable();
            DataTable FarkDt = new DataTable();
            foreach (DataGridViewColumn column in pdfDosyaData.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in pdfDosyaData.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            foreach (DataGridViewColumn column in TxtMaasData.Columns)
            {
                xmlDt.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in TxtMaasData.Rows)
            {
                xmlDt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    xmlDt.Rows[xmlDt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            foreach (DataGridViewColumn column in KarsilastirmaData.Columns)
            {
                FarkDt.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in KarsilastirmaData.Rows)
            {
                FarkDt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    FarkDt.Rows[FarkDt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel Sayfası |*.xlsx" })
                {

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dt, "Ödeme PDF Lİstesi");
                            wb.Worksheets.Add(xmlDt, "Ödeme TXT Lİstesi");
                            wb.Worksheets.Add(FarkDt, "Farklar");
                            wb.SaveAs(sf.FileName);
                            var Klasör = System.IO.Path.GetFullPath(sf.FileName);
                            //MessageBox.Show($"DTO excel dosyanız {folderPath} klasörüne Dtos{DateTime.Now.ToShortDateString()}.xlsx adıyla kayıt edildi", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show($"Ödemeye ait excel dosyanız {Klasör}  adresine kayıt edildi", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu hata kodu {ex.Message.ToString()}", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOlmayanlar.Clear();
            liste.Clear();
            odemeListe.Clear(); 
            pdfDosyaData.DataSource = null;
            TxtMaasData.DataSource = null;
            KarsilastirmaData.DataSource = null;
            btnExcelKaydet.Enabled = false;
            btnKarsilastir.Enabled = false;
            btnTxtDosya.Enabled = false;
            OkumaLbl.Text = null;
            yuzdebar.Value = 0;

        }
    }
}
