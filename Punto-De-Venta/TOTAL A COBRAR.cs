using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class TOTAL_A_COBRAR : Form
    {
        public TOTAL_A_COBRAR(decimal total)
        {
            InitializeComponent();

            LblTotal.Text = $"Total a cobrar: {total.ToString("C")}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
