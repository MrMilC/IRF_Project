using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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
            dgwUsers.AllowUserToAddRows = false;
            labelTime.Text = "\uE72C";
            btnRegister.Text = "\uE8FA";
            btnDelete.Text = "\uE74D";
            btnClear.Text = "\uE894";
            labelError2.Text = "\uE713";
            btnInfo.Text = "\uE897";
            btnTest.Text = "Teszt \nuser";
            cbTermsOfUse.Text = "*Elfogadom a \nfelhasználási feltételeket!";
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            tbPhone.MaxLength = 9;
            tbPIN.MaxLength = 8;
            tbPIN.TextAlign = HorizontalAlignment.Center;
            tbPhone.TextAlign = HorizontalAlignment.Center;
        }

        private void dgwUsersFormazas()
        {
            dgwUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgwUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgwUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgwUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgwUsers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgwUsers.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void WhiteControls()
        {
            tbEmail.BackColor = Color.White;
            tbEmail2.BackColor = Color.White;
            tbPassword.BackColor = Color.White;
            tbPassword2.BackColor = Color.White;
            tbName.BackColor = Color.White;
            tbPIN.BackColor = Color.White;
            tbPhone.BackColor = Color.White;
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            ErrorProv2.Clear();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
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
            if (cbTermsOfUse.Checked == false)
            {
                ErrorProv2.SetError(labelError2, "!El kell fogadni a felhasználási feltételeket");
            }
            else
            {
                if (!ValidateEmail(tbEmail.Text)
                || !ValidatePassword(tbPassword.Text)
                || !ValidateName(tbName.Text)
                || !ValidatePIN(Convert.ToDecimal(tbPIN.Text))
                || !ValidatePhone(tbPhone.Text))
                {
                    ErrorProv2.SetError(labelError2, "!Helytelen formátum(ok) / kitöltetlen mezők" +
                        "\n.A '?' gombra kattintva több információt találhat");
                }
                else
                {
                    if (tbEmail.Text != tbEmail2.Text || tbPassword.Text != tbPassword2.Text)
                    {
                        ErrorProv2.SetError(labelError2, "!A két e-mail cím és/vagy jelszó nem egyezik meg");
                    }
                    else
                    {
                        try
                        {
                            User u = new User()
                            {
                                Nev = tbName.Text,
                                Nem = cbGender.Text,
                                PIN_kod = Convert.ToDecimal(tbPIN.Text),
                                Email = tbEmail.Text,
                                Telefonszam = tbPhone.Text,
                                RegisztracioDatuma = Convert.ToDateTime(DateTime.Now)
                            };
                            users.Add(u);

                            dgwUsersFormazas();

                            Action<Control.ControlCollection> func = null;

                            func = (controls) =>
                            {
                                foreach (Control control in controls)
                                    if (control is System.Windows.Forms.TextBox)
                                        (control as System.Windows.Forms.TextBox).Clear();
                                    else if (control is ComboBox)
                                        (control as ComboBox).SelectedItem = null;
                                    else if (control is System.Windows.Forms.CheckBox)
                                        (control as System.Windows.Forms.CheckBox).Checked = false;
                                    else
                                        func(control.Controls);
                            };

                            func(Controls);

                            WhiteControls();
                        }
                        catch (Exception)
                        {
                            ErrorProv2.SetError(labelError2, "!Kitöltetlen mezők");
                        }
                    }
                }
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
                        (control as ComboBox).SelectedItem = null;
                    else if (control is System.Windows.Forms.CheckBox)
                        (control as System.Windows.Forms.CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };

            func(Controls);

            ErrorProv2.Clear();

            WhiteControls();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            User u = new User()
            {
                Nev = "Teszt Elek",
                Nem = "Férfi",
                PIN_kod = Convert.ToDecimal("19283746"),
                Email = "teszt@valyou.hu",
                Telefonszam = "305555555",
                RegisztracioDatuma = Convert.ToDateTime(DateTime.Now)
            };
            users.Add(u);

            dgwUsersFormazas();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgwUsers.SelectedRows)
                {
                    dgwUsers.Rows.RemoveAt(row.Index);
                }

                dgwUsersFormazas();
            }
            else
            {
                MessageBox.Show("A törléshez legalább egy (egész) sort ki kell jelölni!", "Törlés");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-mail cím formátuma: karakterek/számok@karakterek.karakterek\n" +
                "\nJelszó: Legalább 8 karakter hosszú, csak az angol ABC betűi, számok\nTartalmaznia kell legalább egy kisbetűt, egy nagybetűt és egy számot\n" +
                "\nNév: Legalább két szó, mindkét szó esetén nagy kezdőbetű, a két szó között szóköz\n" +
                "\nPIN-kód: Pontosan 8 számjegy\n" +
                "\nTelefonszám: 20/30/70, majd pontosan 7 számjegy", "Feltételek");
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

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(
                password,
                @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
        }

        public bool ValidateName(string name)
        {
            return Regex.IsMatch(
                name,
                @"[A-ZÖÜÓŐÚÉÁŰ]{1}[a-zöüóőúéáű]{1,}[ ]{1}[A-ZÖÜÓŐÚÉÁŰ]{1}[a-zöüóőúéáű]{1,}");
        }

        public bool ValidatePIN(decimal PIN)
        {
            return Regex.IsMatch(
                PIN.ToString(),
                @"[0-9]{8}");
        }

        public bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(
                phone,
                @"^(20|30|70)[0-9]{3}?[0-9]{4}?$");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            if (regex.IsMatch(tbEmail.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbEmail.Text))
                    tbEmail.BackColor = Color.LightGreen;
                else
                    tbEmail.BackColor = Color.White;
            }

            else
            {
                e.Cancel = false;
                tbEmail.BackColor = Color.OrangeRed;
            }
        }

        private void tbEmail2_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(tbEmail.Text);

            if (regex.IsMatch(tbEmail2.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbEmail2.Text))
                    tbEmail2.BackColor = Color.LightGreen;
                else
                    tbEmail2.BackColor = Color.White;
            }

            else
            {
                e.Cancel = false;
                tbEmail2.BackColor = Color.OrangeRed;
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
            
            if (regex.IsMatch(tbPassword.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbPassword.Text))
                    tbPassword.BackColor = Color.LightGreen;
                else
                    tbPassword.BackColor = Color.White;
            }

            else
            {
                e.Cancel = false;
                tbPassword.BackColor = Color.OrangeRed;
            }
        }

        private void tbPassword2_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(tbPassword.Text);

            if (regex.IsMatch(tbPassword2.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbPassword2.Text))
                    tbPassword2.BackColor = Color.LightGreen;
                else
                    tbPassword2.BackColor = Color.White;
            }

            else
            {
                e.Cancel = false;
                tbPassword2.BackColor = Color.OrangeRed;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"[A-ZÖÜÓŐÚÉÁŰ]{1}[a-zöüóőúéáű]{1,}[ ]{1}[A-ZÖÜÓŐÚÉÁŰ]{1}[a-zöüóőúéáű]{1,}");

            if (regex.IsMatch(tbName.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbName.Text))
                    tbName.BackColor = Color.LightGreen;
                else
                    tbName.BackColor = Color.White;
            }

            else
            {
                e.Cancel = false;
                tbName.BackColor = Color.OrangeRed;
            }
        }

        private void tbPIN_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{8}");

            if (regex.IsMatch(tbPIN.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbPIN.Text))
                    tbPIN.BackColor = Color.LightGreen;
                else
                    tbPIN.BackColor = Color.White;
            }

            else
            {
                e.Cancel = false;
                tbPIN.BackColor = Color.OrangeRed;
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(20|30|70)[0-9]{3}?[0-9]{4}?$");

            if (regex.IsMatch(tbPhone.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbPhone.Text))
                    tbPhone.BackColor = Color.LightGreen;
                else
                    tbPhone.BackColor = Color.White;
            }

            else
            {
                e.Cancel = false;
                tbPhone.BackColor = Color.OrangeRed;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
