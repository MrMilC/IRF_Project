﻿using System;
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

            Formazas();
        }

        private void Belepes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Formazas()
        {
            btnClear.Text = "\uE711";
            btnEnter.Text = "\uE73E";
            labelEye.Text = "\uE7B3";
            tbPIN.MaxLength = 8;
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
    }
}
