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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void КонверторToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        private void ИнфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил: Шингизов Азамат Ис 241 \nРаботу проверил: Тлеубердиева Гульнара");
        }

        private void ИнфоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил: Шингизов Азамат Ис 241 \nРаботу проверил: Тлеубердиева Гульнара");
        }

        private void КонверторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        private void ТаблицаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }
    }
}
