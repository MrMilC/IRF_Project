using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valYOU
{
    public partial class Fomenu : Form
    {
        public Fomenu()
        {
            InitializeComponent();

            FomenuFormazas();
        }

        private void FomenuFormazas()
        {
            labelDown.Text = "\uE70D";
            labelUp.Text = "\uE70E";
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
    }
}
