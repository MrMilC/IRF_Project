using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            //dgwUsers.DataSource = users;
        }

        private void RegisztracioFormazas()
        {
            labelTime.Text = "\uE72C";
            btnRegister.Text = "\uE8FA";
            btnDelete.Text = "\uE74D";
            btnSave.Text = "\uE74E";
            btnClear.Text = "\uE894";
            labelError2.Text = "\uE713";
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            tbPhone.MaxLength = 9;
            tbPIN.MaxLength = 8;
            dgwUsers.AllowUserToAddRows = false;
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
                User u = new User()
                {
                    Vezeteknev = tbLastName.Text,
                    Kozepso_Nev = tbMiddleName.Text,
                    Keresztnev = tbFirstName.Text,
                    Nem = cbGender.Text,
                    PIN_kod = Convert.ToDecimal(tbPIN.Text),
                    Email = tbEmail.Text,
                    Telefonszam = Convert.ToDecimal(tbPhone.Text),
                    RegisztracioDatuma = Convert.ToDateTime(DateTime.Now)
                };
                users.Add(u);
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
                        (control as ComboBox).Items.Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
