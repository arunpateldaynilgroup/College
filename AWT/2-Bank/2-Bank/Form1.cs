using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Bank
{
    public partial class Form1 : Form
    {
        Bank bank = new Bank();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Balance : "+ bank.open(Convert.ToDouble(textBox1.Text)));
            textBox1.Clear();
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deposito Balance : " + bank.deposit(Convert.ToDouble(textBox1.Text)));
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check Balance : " + bank.check());
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Withdraw Balance : " + bank.withdraw(Convert.ToDouble(textBox1.Text)));
            textBox1.Clear();
        }
    }
}
