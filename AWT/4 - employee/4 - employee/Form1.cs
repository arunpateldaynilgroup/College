using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4___employee
{
    public partial class Form1 : Form
    {
        public Employee[] employees = new Employee[10];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employees[count] = new Employee(textBox1.Text, Convert.ToInt32(textBox2.Text));
            count++;
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            for (int i = 0; i < count; i++)
                label3.Text += "Name : " + employees[i].name + " , Age : " + employees[i].age+"\n";

        }
    }
}
