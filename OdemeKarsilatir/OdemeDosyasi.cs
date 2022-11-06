using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdemeKarsilatir
{
    public partial class OdemeDosyasi : Form
    {
        public int yuzdelik = 1;
        public int yuzdeliktepe = 0;
        public int oran = 1;
        public OdemeDosyasi()
        {
            InitializeComponent();
        }


        private void btnPdfDosyaSec_Click_1(object sender, EventArgs e)
        {
            string strText = string.Empty;
            List<string[]> st = new List<string[]>();
            List<KisiOdeme> odemeListe = new List<KisiOdeme>();
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
                    yuzdeliktepe = intPageNum;
                    yuzdebar.Step = 1;

                    for (int page = 1; page <= intPageNum; page++)
                    {

                        yuzdebar.Value = page;
                        yuzdelik++;
                        oran = Convert.ToInt32((yuzdelik / yuzdeliktepe) * 100);

                        //label1.Text = yuzdebar.Value.ToString();
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

                MessageBox.Show($"{filepath} dosyasındaki {intPageNum} kadar sayfa okundu. Toplam {odemeListe.Count} kayıt getirildi", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}
