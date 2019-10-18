using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Srs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double sum=0.0;
            try
            {
                sum = System.Convert.ToDouble(textBox1.Text);
                if (sum < 0)
                {
                    MessageBox.Show("Вес не может быть отрицательным");
                }
                
            }
            catch (FormatException) {
                MessageBox.Show("Введите число(-а)");
            }
            sum = sum / 1024;
            label2.Text = System.Convert.ToString(sum) + " TB";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            try
            {
                sum = System.Convert.ToDouble(textBox1.Text);
                if (sum < 0)
                {
                    MessageBox.Show("Вес не может быть отрицательным");
                }
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Введите число(-а)");
            }
            sum = sum * 1024;
            label1.Text = System.Convert.ToString(sum) + " MB";
        }
    }
}
