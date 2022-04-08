﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_OOP
{
    public partial class Login : Form
    {
        public int id { get; private set; }
        public int senha { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.id = Int32.Parse(txtId.Text);
            this.senha = Int32.Parse(txtSenha.Text);
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                btnLogar.Enabled = false;
            }
            else
            {
                btnLogar.Enabled = true;
            }
        }
    }
}