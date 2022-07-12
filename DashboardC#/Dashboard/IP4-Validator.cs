using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Dashboard
{
    public partial class IP4_Validator : Form
    {
        public IP4_Validator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app.?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
                // Application.Exit();
            }
            else
            {
                Default();
            }
        }

        void Default()
        {
            label1.Text = "";

            textBox1.Text = "0";
            textBox1.ReadOnly = false;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Default();
        }

        private void IP4_Validator_Load(object sender, EventArgs e)
        {
           
            label1.Text += DateTime.Today.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                Regex myobj = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
                //(@"^(\d[0-255]{1,3})\.(\d[0-255]{1,3})\.(\d[0-255]{1,3})\.(\d[0-255]{1,3})$");

                if (myobj.IsMatch(textBox1.Text.Trim())) // how to use Split() separated by a specific separator 


                {
                    MessageBox.Show("This IP is correct", textBox1.Text.ToString());



                }
                else
                {
                    MessageBox.Show("The IP must have 4 bytes \n integer number between 0 to 255 \n separated by dot (255.255.255.255)", textBox1.Text.ToString());
                }
            }

            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
