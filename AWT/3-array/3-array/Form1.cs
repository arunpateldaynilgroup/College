using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_array
{
    public partial class Form1 : Form
    {
        int[] num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            private void button1_Click(object sender, EventArgs e)
            {
                num = new int[10];
                string s = textBox1.Text;
                string[] a = s.Split(' ');
                int c = 0;
                foreach (string i in a)
                {
                    num[c] = int.Parse(i);
                    c++;
                }
                label2.Text = "CReated Array is : ";
                for (int i = 0; i < num.Length; i++)
                    label2.Text += " " + num[i].ToString();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                for (int i = 0; i < num.Length; i++)
                    for (int j = 0; j < i; j++)
                    {
                        if (num[j] > num[i])
                        {
                            int temp = num[j];
                            num[j] = num[i];
                            num[i] = temp;
                        }
                    }
                label3.Text = "Soted Array : ";
                for (int i = 0; i < num.Length; i++)
                    label3.Text += " " + num[i].ToString();
            }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
