using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteCollatz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncollatz_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtnumero.Text);
            ServiceReference1.IcontratoCollatzClient cliente =
                new ServiceReference1.IcontratoCollatzClient();
            int[] collatz = cliente.GetConjeturaCollatz(numero);
            this.lstnumeros.Items.Clear();
            foreach(int n in collatz)
            {
                this.lstnumeros.Items.Add(n);
            }
        }
    }
}
