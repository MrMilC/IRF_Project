using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valYOU
{
    public partial class Belepes : Form
    {
        public Belepes()
        {
            InitializeComponent();

            BelepesFormazas();
        }

        private void Belepes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos ki szeretne lépni?", "Megerősítés",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BelepesFormazas()
        {
            btnClear.Text = "\uE711";
            btnEnter.Text = "\uE73E";
            labelEye.Text = "\uE7B3";
            btnFastLogin.Text = "\uF3B1";
            tbPIN.MaxLength = 8;
            tbPIN.TextAlign = HorizontalAlignment.Center;
        }

        Control ActiveControl;
        private void btnOne_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }

        private void tbPIN_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPIN.Clear();

            if (cbVisible is CheckBox)
            {
                ((CheckBox)cbVisible).Checked = false;
            }
        }

        private void Belepes_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbPIN;
        }

        private void cbVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVisible.Checked==true)
            {
                tbPIN.UseSystemPasswordChar = false;
            }

            else
            {
                tbPIN.UseSystemPasswordChar = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPIN.Text))
                MessageBox.Show("Kérjük adja meg a PIN-kódot!");

            else if (tbPIN.TextLength != 8)
                MessageBox.Show("A PIN-kód nem 8 számjegyű!");

            else if (tbPIN.Text != "91827364")
                MessageBox.Show("Helytelen PIN-kód!");

            else
            {
                MessageBox.Show("Köszöntjük a valYOU applikáció 0.1-es verziójában!");

                using (Fomenu fm = new Fomenu())
                {
                    fm.ShowDialog();
                }
            }              
        }

        private void btnFastLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Köszöntjük a valYOU applikáció 0.1-es verziójában!");

            using (Fomenu fm = new Fomenu())
            {
                fm.ShowDialog();
            }
        }

        private void tbPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPIN_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{8}");

            if (regex.IsMatch(tbPIN.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(tbPIN.Text))
                    tbPIN.BackColor = Color.White;
            }

            else
            {
                e.Cancel = false;
                tbPIN.BackColor = Color.Tomato;
            }
        }

        private void tbPIN_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
