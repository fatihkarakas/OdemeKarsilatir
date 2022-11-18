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
using Aspose.Pdf.Text;

namespace OdemeKarsilatir
{
    public partial class OdemeDosyasi : Form
    {
        public List<KisiOdeme> odemeListe = new List<KisiOdeme>();
        public List<txtSource> listeTxtFile = new List<txtSource>();
        public List<KisiOdeme> txtOlmayanlar = new List<KisiOdeme>();
        public OdemeDosyasi()
        {
            InitializeComponent();
        }

        public void test(string path)
        {
            Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(path);

            // Loop through the pages                      
            foreach (var page in pdfDocument.Pages)
            {
                // Create a table absorber and visit the page
                Aspose.Pdf.Text.TableAbsorber absorber = new Aspose.Pdf.Text.TableAbsorber();
                absorber.Visit(page);

                // Loop through each absorbed table 
                foreach (AbsorbedTable table in absorber.TableList)
                {
                    Console.WriteLine("Table");

                    // Loop through each row in the table
                    foreach (AbsorbedRow row in table.RowList)
                    {
                        // Loop through each cell in the row
                        foreach (AbsorbedCell cell in row.CellList)
                        {
                            // Loop through the text fragments
                            foreach (TextFragment fragment in cell.TextFragments)
                            {
                                var sb = new StringBuilder();
                                foreach (TextSegment seg in fragment.Segments)
                                    sb.Append(seg.Text);
                                Console.Write($"{sb.ToString()}|");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }


        private void btnPdfDosyaSec_Click_1(object sender, EventArgs e)
        {
            odemeListe.Clear();
            pdfDosyaData.DataSource = null;
            string strText = string.Empty;
            List<string[]> st = new List<string[]>();

            OpenFileDialog ofd = new OpenFileDialog();
            string filepath;
            ofd.Filter = "PDF Files(*.PDF)|*.PDF|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filepath = ofd.FileName.ToString();
                PdfReader reader = new PdfReader(filepath);
                test(filepath);
                int intPageNum = reader.NumberOfPages;
                string[] words;
                string[] line1;
                try
                {     // todo BUrada PDF table okuma ayarları aspose ile denendi fakat olmadı
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
                        var s = PdfTextExtractor.GetTextFromPage(reader, page,its);
                        s= Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default,Encoding.UTF8,Encoding.Default.GetBytes(s)));
                        words = s.Replace(" ","*").Split('\n');
                        //Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(filepath);
                        //Aspose.Pdf.ExcelSaveOptions options = new Aspose.Pdf.ExcelSaveOptions();
                        //// Save output file
                        //pdfDocument.Save("Excel.xls", options);
                        for (int i = 0; i < words.Length; i++)
                        {
                            line1 = words[i].Trim().Split('*');
                            st.Add(line1);
                        }
                        
                        Console.WriteLine(s);
                    }
                    foreach (string[] item in st)
                    {
                        string[] tutar = item[item.Length - 1].Split(',');

                        if (tutar.Length == 2 && item.Length >= 6 && item[0].Length < 10)
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
                            string AdSoyadBilgi = "";
                            for (int i = 2; i < item.Length - 2; i++)
                            {
                                AdSoyadBilgi += item[i] + " ";
                            }
                            var kisi = new KisiOdeme()
                            {
                                Sira = Convert.ToInt32(item[0]),
                                tck = item[1],
                                adisoyadi = AdSoyadBilgi,//$"{item[2]} {item[3]}",
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
                    MessageBox.Show($"İşlem Sırasında bir hata oluştu\n Hata Kod: {ex.Message.ToString()}", "İşlme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            listeTxtFile.Clear();
            TxtMaasData.DataSource = null;
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
                                ibankontrol(txtSource.Iban);
                            }
                            else
                            {
                                txtSource.Iban = $"{txtSource.BankaKod.Substring(0,4)}{txtSource.BankaSube}{txtSource.BankaHesapNo}";
                               var snc = ibankontrol(txtSource.Iban);

                            }
                            listeTxtFile.Add(txtSource);
                        }

                    }
                    decimal ToplamTutar = listeTxtFile.Sum(x => x.Odenecek);
                    MessageBox.Show($"Toplam Ödenecek Tutar : {ToplamTutar}", "Bilgilendirme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtMaasData.DataSource = listeTxtFile;
                    TxtMaasData.Visible = true;
                    OkumaLbl.Text = $"Toplam Ödenecek Tutar : {ToplamTutar}";
                    btnKarsilastir.Enabled = true;
                    btnTxtDosya.Enabled = true;
                    MessageBox.Show($"{adresPath} dosyasındaki txt verileri okundu . Toplam {listeTxtFile.Count} kayıt getirildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"İşlem Sırasında bir hata oluştu\n Hata Kod: {ex.Message.ToString()}", "İşlme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = Cursors.Default;
        }
        public static bool ibankontrol(string bankAccount)
        {
            try
            {
                bankAccount = bankAccount.ToUpper();
                if (String.IsNullOrEmpty(bankAccount))
                    return false;
                else if (System.Text.RegularExpressions.Regex.IsMatch(bankAccount, "^[A-Z0-9]"))
                {
                    bankAccount = bankAccount.Replace(" ", String.Empty);
                    string bank =
                    bankAccount.Substring(4, bankAccount.Length - 4) + bankAccount.Substring(0, 4);
                    int asciiShift = 55;
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in bank)
                    {
                        int v;
                        if (Char.IsLetter(c)) v = c - asciiShift;
                        else v = int.Parse(c.ToString());
                        sb.Append(v);
                    }
                    string checkSumString = sb.ToString();
                    int checksum = int.Parse(checkSumString.Substring(0, 1));
                    for (int i = 1; i < checkSumString.Length; i++)
                    {
                        int v = int.Parse(checkSumString.Substring(i, 1));
                        checksum *= 10;
                        checksum += v;
                        checksum %= 97;
                    }
                    return checksum == 1;
                }

                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            txtOlmayanlar.Clear();
            KarsilastirmaData.DataSource = null;
            yuzdebar.Maximum = 100;
            try
            {
                int deger = 1;
                foreach (var item in odemeListe)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var KIban = item.Iban.Substring(item.Iban.Length - 16);

                    if (!listeTxtFile.Any(x => x.Iban.Contains(KIban)) || listeTxtFile.Where(x => x.Iban.Contains(KIban) && x.Odenecek != item.Odeme).ToList().Count !=0)
                    {
                        txtOlmayanlar.Add(item);
                    }
                 
                    //item.Iban = item.Iban == string.Empty ? liste.FirstOrDefault(x => x.BankaSube.Contains(item.Iban) && x.BankaKod.Contains(item.Iban)).Iban:item.Iban;

                    yuzdebar.Value = Convert.ToInt32((deger) * (100) / odemeListe.Count);
                    deger++;
                }
                foreach (var item in listeTxtFile)
                {
                    var KIban = item.Iban.Substring(item.Iban.Length - 16);

                    var say = odemeListe.FindAll(x => x.Iban.Substring(x.Iban.Length - 16).Contains(KIban)).Count;
                    if (odemeListe.Where(x => x.Iban.Contains(KIban)).ToList().Count==0 )
                    {
                        var k = new KisiOdeme()
                        {
                            Sira = 0,
                            tck = "PDF dosyasında Kişi Bilgisi Yok",
                            adisoyadi = $"{item.Adi} {item.Soyadi}",
                            Iban = item.Iban.Substring(item.Iban.Length - 15),
                            Odeme = item.Odenecek
                        };
                        txtOlmayanlar.Add(k);
                    }
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlem Sırasında bir hata oluştu\n Hata Kod: {ex.Message.ToString()}", "İşlme Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
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
            listeTxtFile.Clear();
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
