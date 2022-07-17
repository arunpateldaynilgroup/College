using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6___Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.set(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            MessageBox.Show("Area Of Reactangle : " + rectangle.getArea());
        }
    }
}
