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

            dgwUsers.DataSource = users;
        }

        private void RegisztracioFormazas()
        {
            labelTime.Text = "\uE72C";
            btnRegister.Text = "\uE8FA";
            btnDelete.Text = "\uE74D";
            btnSave.Text = "\uE74E";
            btnClear.Text = "\uE894";
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            tbPhone.MaxLength = 9;
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
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
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
            User u = new User()
            {
                Vezeteknev = tbLastName.Text,
                KozepsoNev = tbMiddleName.Text,
                Keresztnev = tbFirstName.Text,
                Nem = cbGender.Text,
                Email = tbEmail.Text,
                Telefonszam = Convert.ToDecimal(tbPhone.Text),
                RegisztracioDatuma = Convert.ToDateTime(DateTime.Now)
            };
            users.Add(u);
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
