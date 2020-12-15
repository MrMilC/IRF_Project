using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using valYOU.Entities;
using valYOU.MNBArfolyamServiceReference;

namespace valYOU
{
    public partial class Arfolyamok : Form
    {
        BindingList<Rate> Rates = new BindingList<Rate>();
        BindingList<string> Currencies = new BindingList<string>();

        public Arfolyamok()
        {
            InitializeComponent();

            CurrencyList();
            DataRefresh();
            ArfolyamokDesign();
        }

        private void CurrencyList()
        {
            var MNBservice = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody();
            var response = MNBservice.GetCurrencies(request);
            var result = response.GetCurrenciesResult;

            var xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement element in xml.DocumentElement.ChildNodes[0])
            {
                var currency = element.InnerText;
                Currencies.Add(currency);
            }

            cbCurrency.DataSource = Currencies;
        }

        private void DataRefresh()
        {
            Rates.Clear();

            string s = WebService();
            XMLload(s);

            dgwRates.DataSource = Rates;
            RateDiagram();

            Calculations();
        }

        private void ArfolyamokDesign()
        {
            labelRightArrow.Text = "\uE970";
            labelError.Text = "\uE713";
            dtpFrom.Value = new DateTime(2020, 01, 01);
            dtpTo.Value = new DateTime(2020, 01, 31);
            cbCurrency.SelectedItem = "EUR";
            dgwRates.AllowUserToAddRows = false;
            dgwRates.ReadOnly = true;
            btnIntoImage.Text="PNG \nJPG";
        }

        private string WebService()
        {
            var MNBservice = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = cbCurrency.SelectedItem.ToString(),
                startDate = dtpFrom.Value.ToString(),
                endDate = dtpTo.Value.ToString()
            };

            var response = MNBservice.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            return result;
        }

        private void XMLload(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new Rate();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childelement = (XmlElement)element.ChildNodes[0];
                if (childelement == null)
                    continue;
                rate.Currency = childelement.GetAttribute("curr");

                var unit = decimal.Parse(childelement.GetAttribute("unit"));
                var value = decimal.Parse(childelement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private void RateDiagram()
        {
            chartRates.DataSource = Rates;

            var series = chartRates.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 1;
            series.Color = Color.Orange;

            var legend = chartRates.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRates.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void Calculations()
        {
            try
            {
                var values = from DataGridViewRow row in dgwRates.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDecimal(row.Cells[2].FormattedValue);

                var minValue = values.Min();
                var avgValue = values.Average();
                var maxValue = values.Max();

                labelMin.Text = Math.Round(minValue, 2).ToString() + " HUF";
                labelAvg.Text = Math.Round(avgValue, 2).ToString() + " HUF";
                labelMax.Text = Math.Round(maxValue, 2).ToString() + " HUF";

                foreach (DataGridViewRow row in dgwRates.Rows)
                {
                    if (Convert.ToDecimal(row.Cells[2].Value) == minValue)
                    {
                        row.DefaultCellStyle.BackColor = Color.Lime;
                    }
                    else if (Convert.ToDecimal(row.Cells[2].Value) == maxValue)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (dgwRates.Rows.Count==1 || Convert.ToDecimal(row.Cells[2].Value) == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }

            catch (Exception)
            {
                if (dtpFrom.Value > dtpTo.Value)
                    ErrorProv.SetError(labelError, "A kezdő dátum nem lehet a záró dátumnál későbbi időpont!");

                else if (dgwRates.Rows.Count == 0)
                    ErrorProv.SetError(labelError, "Az adott szűrési feltételek mellett nem léteznek adatok!");

                labelMin.Text = "N/A";
                labelAvg.Text = "N/A";
                labelMax.Text = "N/A";
            }
        }

        private void Arfolyamok_Load(object sender, EventArgs e)
        {
            Calculations();
        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorProv.Clear();
            DataRefresh();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            ErrorProv.Clear();
            DataRefresh();
        }

        private void btnIntoCSV_Click(object sender, EventArgs e)
        {
            if (dgwRates.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.Title = "Árfolyam mentése CSV fájlba";
                sfd.FileName = ".csv";
                sfd.RestoreDirectory = true;
                bool fileError = false;
                DialogResult result = sfd.ShowDialog();

                if (result == DialogResult.OK && sfd.FileName != "")
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Sikertelen mentés: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            if (sfd.CheckPathExists)
                            {
                                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                                {
                                    sw.WriteLine("Árfolyam " + "|" + cbCurrency.Text + "|");
                                    sw.WriteLine();

                                    sw.WriteLine("Minimális érték: " + labelMin.Text);
                                    sw.WriteLine("Átlagos érték: " + labelAvg.Text);
                                    sw.WriteLine("Maximális érték: " + labelMax.Text);
                                    sw.WriteLine();
                                    sw.WriteLine();
                                    sw.WriteLine();

                                    for (int i = 0; i < dgwRates.Rows.Count; i++)
                                    {
                                        sw.WriteLine("Dátum: " + dgwRates.Rows[i].Cells[0].Value.ToString().Substring(0, 13));
                                        sw.WriteLine("Érték: " + dgwRates.Rows[i].Cells[2].Value.ToString() + " HUF");
                                        sw.WriteLine();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("A megadott útvonal nem létezik!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hiba: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincsenek exportálható adatok!", "Hiba");
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Kivétel történt az objektum feloldásakor: " + ex.Message, "Hiba");
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnIntoExcel_Click(object sender, EventArgs e)
        {
            if (dgwRates.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel-munkafüzet|*.xlsx";
                sfd.Title = "Árfolyam mentése Excel fájlba";
                sfd.FileName = ".xlsx";
                sfd.RestoreDirectory = true;
                bool fileError = false;
                DialogResult result = sfd.ShowDialog();

                if (result == DialogResult.OK && sfd.FileName != "")
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Sikertelen mentés: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            if (sfd.CheckPathExists)
                            {
                                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                                _Workbook wb = excel.Workbooks.Add(Type.Missing);
                                _Worksheet ws = null;

                                ws = wb.Sheets["Munka1"];
                                ws = wb.ActiveSheet;
                                ws.Name = "Árfolyamok";
                                ws.Application.ActiveWindow.SplitRow = 1;
                                ws.Application.ActiveWindow.FreezePanes = true;

                                for (int i = 1; i < dgwRates.Columns.Count + 1; i++)
                                {
                                    ws.Cells[1, i] = dgwRates.Columns[i - 1].HeaderText;
                                    ws.Cells[1, i].Font.NAME = "Arial";
                                    ws.Cells[1, i].Font.Bold = true;
                                    ws.Cells[1, i].Font.Size = 12;
                                    ws.Cells[1, i].VerticalAlignment = XlVAlign.xlVAlignCenter;
                                    ws.Cells[1, i].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                                    ws.Cells[1, i].Interior.Color = Color.LimeGreen;
                                    ws.Cells[1, i].Font.Color = Color.White;
                                    ws.Cells[1, i].EntireColumn.AutoFit();
                                    ws.Cells[1, i].RowHeight = 30;
                                    ws.Cells[1, i].BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThick);
                                }

                                for (int i = 0; i < dgwRates.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dgwRates.Columns.Count; j++)
                                    {
                                        ws.Cells[i + 2, j + 1] = dgwRates.Rows[i].Cells[j].Value.ToString();
                                    }
                                }

                                ws.Columns.AutoFit();
                                wb.SaveAs(sfd.FileName);
                                excel.Quit();

                                ReleaseObject(ws);
                                ReleaseObject(wb);
                                ReleaseObject(excel);
                            }
                            else
                            {
                                MessageBox.Show("A megadott útvonal nem létezik!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hiba: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincsenek exportálható adatok!", "Hiba");
            }
        }

        private void btnIntoPDF_Click(object sender, EventArgs e)
        {
            if (dgwRates.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.Title = "Árfolyam mentése PDF fájlba";
                sfd.FileName = ".pdf";
                sfd.RestoreDirectory = true;
                bool fileError = false;
                DialogResult result = sfd.ShowDialog();

                if (result == DialogResult.OK && sfd.FileName != "")
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Sikertelen mentés: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            if (sfd.CheckPathExists)
                            {
                                PdfPTable pdfTable = new PdfPTable(dgwRates.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 75;
                                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                                foreach (DataGridViewColumn column in dgwRates.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dgwRates.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("A megadott útvonal nem létezik!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hiba: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincsenek exportálható adatok!", "Hiba");
            }
        }

        private void btnIntoImage_Click(object sender, EventArgs e)
        {
            if (dgwRates.Rows.Count > 1)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
                sfd.Title = "Diagram mentése képként";
                sfd.FileName = cbCurrency.Text + " árfolyam.png";
                sfd.RestoreDirectory = true;
                bool fileError = false;
                DialogResult result = sfd.ShowDialog();

                if (result == DialogResult.OK && sfd.FileName != "")
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Sikertelen mentés: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            if (sfd.CheckPathExists)
                            {
                                if (sfd.FilterIndex == 2)
                                {
                                    chartRates.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
                                    sfd.FileName = cbCurrency.Text + " árfolyam.jpg";
                                }
                                else if (sfd.FilterIndex == 1)
                                {
                                    chartRates.SaveImage(sfd.FileName, ChartImageFormat.Png);
                                    sfd.FileName = cbCurrency.Text + " árfolyam.png";
                                }
                            }
                            else
                            {
                                MessageBox.Show("A megadott útvonal nem létezik!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hiba: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincsenek exportálható adatok!" +
                    "\nVAGY" +
                    "\nNem áll rendelkezésre elegendő adat!", "Hiba");
            }
        }
    }
}
