using System;
using System.Windows.Forms;

namespace valYOU
{
    public partial class Fomenu : Form
    {
        public Fomenu()
        {
            InitializeComponent();

            FomenuDesign();
        }

        private void FomenuDesign()
        {
            labelUp1.Text = "\uE70E";
            labelUp2.Text = "\uE70E";
            labelDown1.Text = "\uE70D";
            labelDown2.Text = "\uE70D";
        }

        private void btnRates_Click(object sender, EventArgs e)
        {
            using (Arfolyamok af = new Arfolyamok())
            {
                af.ShowDialog();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            using (Regisztracio reg=new Regisztracio())
            {
                reg.ShowDialog();
            }
        }

        private void btnRates_MouseEnter(object sender, EventArgs e)
        {
            labelUp1.Visible = true;
            labelDown1.Visible = true;
        }

        private void btnRates_MouseLeave(object sender, EventArgs e)
        {
            labelUp1.Visible = false;
            labelDown1.Visible = false;
        }

        private void btnRegistration_MouseEnter(object sender, EventArgs e)
        {
            labelUp2.Visible = true;
            labelDown2.Visible = true;
        }

        private void btnRegistration_MouseLeave(object sender, EventArgs e)
        {
            labelUp2.Visible = false;
            labelDown2.Visible = false;
        }
    }
}
