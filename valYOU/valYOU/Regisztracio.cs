using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using valYOU.Entities;

namespace valYOU
{
    public partial class Regisztracio : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Regisztracio()
        {
            InitializeComponent();

            RegisztracioFormazas();

            dgwUsers.DataSource = users;
        }

        private void RegisztracioFormazas()
        {
            labelTime.Text = "\uE72C";
            btnRegister.Text = "\uE8FA";
            btnDelete.Text = "\uE74D";
            btnClear.Text = "\uE894";
            labelError2.Text = "\uE713";
            btnTest.Text = "Teszt \nuser";
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            tbPhone.MaxLength = 9;
            tbPIN.MaxLength = 8;
            dgwUsers.AllowUserToAddRows = false;

            for (int i = 0; i <= dgwUsers.Columns.Count - 1; i++)
            {
                int colw = dgwUsers.Columns[i].Width;
                dgwUsers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgwUsers.Columns[i].Width = colw;
            }
        }


        private void Regisztracio_Load(object sender, EventArgs e)
        {

        }

        private void timerReg_Tick(object sender, EventArgs e)
        {
            
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tbMiddleName.Text))
                {
                    User u = new User()
                    {
                        Nev = tbLastName.Text + " " + tbMiddleName.Text + " " + tbFirstName.Text,
                        Nem = cbGender.Text,
                        PIN_kod = Convert.ToDecimal(tbPIN.Text),
                        Email = tbEmail.Text,
                        Telefonszam = Convert.ToDecimal(tbPhone.Text),
                        RegisztracioDatuma = Convert.ToDateTime(DateTime.Now)
                    };
                    users.Add(u);
                }
                else
                {
                    User u = new User()
                    {
                        Nev = tbLastName.Text + " " + tbFirstName.Text,
                        Nem = cbGender.Text,
                        PIN_kod = Convert.ToDecimal(tbPIN.Text),
                        Email = tbEmail.Text,
                        Telefonszam = Convert.ToDecimal(tbPhone.Text),
                        RegisztracioDatuma = Convert.ToDateTime(DateTime.Now)
                    };
                    users.Add(u);
                }
                
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is System.Windows.Forms.TextBox)
                            (control as System.Windows.Forms.TextBox).Clear();
                        else if (control is ComboBox)
                            (control as ComboBox).Items.Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);
            }
            catch (Exception)
            {
                ErrorProv2.SetError(labelError2, "!Kitöltetlen adatok");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is System.Windows.Forms.TextBox)
                        (control as System.Windows.Forms.TextBox).Clear();
                    else if (control is ComboBox)
                        cbGender.SelectedItem = null;
                    else
                        func(control.Controls);
            };

            func(Controls);

            ErrorProv2.Clear();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            User u = new User()
            {
                Nev = "Teszt Elek",
                Nem = "Férfi",
                PIN_kod = Convert.ToDecimal("19283746"),
                Email = "teszt@valyou.hu",
                Telefonszam = Convert.ToDecimal("305555555"),
                RegisztracioDatuma = Convert.ToDateTime(DateTime.Now)
            };
            users.Add(u);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgwUsers.SelectedRows)
                {
                    dgwUsers.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("A törléshez legalább egy egész sort ki kell jelölni!", "Törlés");
            }
        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {
            ErrorProv2.Clear();
        }

        private void btnIntoCSV_Click(object sender, EventArgs e)
        {
            if (dgwUsers.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.Title = "Felhasználók mentése CSV fájlba";
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
                            MessageBox.Show("Sikertelen mentés" + ex.Message);
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
                                    sw.WriteLine("Eddigi felhasználók");
                                    sw.WriteLine();

                                    for (int i = 0; i < dgwUsers.Rows.Count; i++)
                                    {
                                        sw.WriteLine("Név: " + dgwUsers.Rows[i].Cells[0].Value.ToString());
                                        sw.WriteLine("Nem: " + dgwUsers.Rows[i].Cells[1].Value.ToString());
                                        sw.WriteLine("PIN-kód: " + dgwUsers.Rows[i].Cells[2].Value.ToString());
                                        sw.WriteLine("E-mail cím: " + dgwUsers.Rows[i].Cells[3].Value.ToString());
                                        sw.WriteLine("Telefonszám: " + dgwUsers.Rows[i].Cells[4].Value.ToString());
                                        sw.WriteLine("Regisztráció dátuma: " + dgwUsers.Rows[i].Cells[5].Value.ToString());
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
                MessageBox.Show("Kivétel történt az objektum feloldásakor " + ex.Message, "Hiba");
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnIntoExcel_Click(object sender, EventArgs e)
        {
            if (dgwUsers.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel-munkafüzet|*.xlsx";
                sfd.Title = "Felhasználók mentése Excel fájlba";
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
                            MessageBox.Show("Sikertelen mentés" + ex.Message);
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
                                ws.Name = "Felhasználók";
                                ws.Application.ActiveWindow.SplitRow = 1;
                                ws.Application.ActiveWindow.FreezePanes = true;

                                for (int i = 1; i < dgwUsers.Columns.Count + 1; i++)
                                {
                                    ws.Cells[1, i] = dgwUsers.Columns[i - 1].HeaderText;
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

                                for (int i = 0; i < dgwUsers.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dgwUsers.Columns.Count; j++)
                                    {
                                        ws.Cells[i + 2, j + 1] = dgwUsers.Rows[i].Cells[j].Value.ToString();
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
            if (dgwUsers.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.Title = "Felhasználók mentése PDF fájlba";
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
                            MessageBox.Show("Sikertelen mentés" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            if (sfd.CheckPathExists)
                            {
                                PdfPTable pdfTable = new PdfPTable(dgwUsers.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dgwUsers.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dgwUsers.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A3, 10f, 20f, 20f, 10f);
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
    }
}
