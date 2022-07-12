using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lotto_649 obj = new Lotto_649();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the app?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString()== "Yes") 

            { Application.Exit(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoneyExchange_Girenko obj = new MoneyExchange_Girenko();
            obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            obj.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            convert_temperature obj = new convert_temperature();
            obj.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IP4_Validator obj = new IP4_Validator();
            obj.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
