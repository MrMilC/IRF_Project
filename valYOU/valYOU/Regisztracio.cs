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
            btnSave.Text = "\uE74E";
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
                        if (control is TextBox)
                            (control as TextBox).Clear();
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
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        cbGender.SelectedItem = null;
                    else
                        func(control.Controls);
            };

            func(Controls);

            ErrorProv2.Clear();
        }

        private void btnIntoCSV_Click(object sender, EventArgs e)
        {
            if (dgwUsers.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.Title = "Felhasználók mentése CSV-ként";
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
                                        sw.WriteLine("Név: "+dgwUsers.Rows[i].Cells[0].Value.ToString());
                                        sw.WriteLine("Nem: "+dgwUsers.Rows[i].Cells[1].Value.ToString());
                                        sw.WriteLine("PIN-kód: "+dgwUsers.Rows[i].Cells[2].Value.ToString());
                                        sw.WriteLine("E-mail cím: "+dgwUsers.Rows[i].Cells[3].Value.ToString());
                                        sw.WriteLine("Telefonszám: "+dgwUsers.Rows[i].Cells[4].Value.ToString());
                                        sw.WriteLine("Regisztráció dátuma: "+dgwUsers.Rows[i].Cells[5].Value.ToString());
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

        private void btnIntoExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnIntoPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            User u = new User()
            {
                Nev = "Teszt Elek",
                Nem = "Férfi",
                PIN_kod = Convert.ToDecimal("91827364"),
                Email = "teszt@valyou.hu",
                Telefonszam = Convert.ToDecimal("305555555"),
                RegisztracioDatuma = Convert.ToDateTime(DateTime.Now)
            };
            users.Add(u);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgwUsers.SelectedRows)
            {
                dgwUsers.Rows.RemoveAt(row.Index);
            }
        }
    }
}
