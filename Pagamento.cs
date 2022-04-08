using System;
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
    public partial class Pagamento : Form
    {
        public int valor { get; set; }
        public Pagamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.valor = Int32.Parse(txtValor.Text);
            this.Close();
        }
    }
}
