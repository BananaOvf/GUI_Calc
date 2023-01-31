using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            int num1, num2;
            
            int.TryParse(textBox_Num1.Text, out num1);
            int.TryParse(textBox_Num2.Text, out num2);

            label_sum.Text = (num1 + num2).ToString(); // Сложение
            label_sub.Text = (num1 - num2).ToString(); // Разность
            label_mul.Text = (num1 * num2).ToString(); // Произведение
            label_div.Text = (num1 / num2).ToString(); // Частное
        }
    }
}
