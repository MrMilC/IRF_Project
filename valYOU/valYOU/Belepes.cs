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
    public partial class Belepes : Form
    {
        public Belepes()
        {
            InitializeComponent();
        }

        private void Belepes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
