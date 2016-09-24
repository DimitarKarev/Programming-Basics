using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08.BGN_to_EUR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }
        void Convert()
        {
            var amount = this.numericUpDownAmount.Value;
            var amountInEuro = amount / 1.95583m;
            this.labelResult.Text = Math.Round(amount, 2) + " BGN = " + Math.Round(amountInEuro, 2) + " EUR";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Convert();
        }
    }
}
