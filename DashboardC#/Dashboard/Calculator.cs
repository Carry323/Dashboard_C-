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
    public partial class Calculator : Form
    {

        private Calculator1 obj;
        private bool IsEqualPressed = false;
        public void Check(string displayValue)
        {


            if (textBox1.Text == "+")
            {

                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {

                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {

                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {

                textBox1.Text = "";
            }

            if (IsEqualPressed)
            {
                IsEqualPressed = false;
                textBox1.Text = "";
            }
        }
        public Calculator()
        {
            InitializeComponent();
        }


        public class Calculator1
        {


            private decimal currentValue;

            public decimal CurrentValue
            {
                set { currentValue = value; } //write into private field
                get { return currentValue; }  //read private field value
            }

            private decimal operand1;


            private decimal operand2;


            private string op;

            public Calculator1() { }

            public Calculator1(decimal currentValue)
            {
                this.CurrentValue = currentValue;
            }

            public void Add(string displayValue)
            {

                operand1 = Convert.ToDecimal(displayValue);
                currentValue = operand1;
                op = "+";

            }
            public void Subtract(string displayValue)
            {
                operand1 = Convert.ToDecimal(displayValue);
                currentValue = operand1;
                op = "-";
            }
            public void Multiply(string displayValue)
            {
                operand1 = Convert.ToDecimal(displayValue);
                currentValue = operand1;
                op = "*";
            }
            public void Divide(string displayValue)
            {
                operand1 = Convert.ToDecimal(displayValue);
                currentValue = operand1;
                op = "/";
            }

        
   

            public void Equals(string displayValue) 
            {
               
                operand2 = Convert.ToDecimal(displayValue);

                switch (op)
                {
                    case "+":
                        operand1 = operand1 + operand2;
                        break;
                    case "-":
                        operand1 = operand1 - operand2;
                        break;
                    case "*":
                        operand1 = operand1 * operand2;
                        break;
                    case "/":
                        try
                        {
                            operand1 = operand1 / operand2;
                        }
                        catch
                        {
                            currentValue = 0;
                            operand1 = 0;
                            operand2 = 0;
                        }
                        
                        break;
                    default:
                        break;
                }

                currentValue = operand1;
            }

            public void Equals()
            {
                
            }
            public void Clear() 
            {
                operand1 = 0;
                operand2 = 0;
                currentValue = 0;
            }
        }


            

        
        private void button1_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);

             textBox1.Text = textBox1.Text + 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 3;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
            textBox1.Text = textBox1.Text + ".";
        }

        
        private void button12_Click(object sender, EventArgs e)
        {

            
            obj.Add(textBox1.Text);
            textBox1.Text = "+";
            textBox1.Focus();
            

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox1.Text) !=0)
            {
                obj.Equals(textBox1.Text);

                textBox1.Text = obj.CurrentValue.ToString();
                obj.CurrentValue = 0;
                IsEqualPressed = true;
            }

            else 
            {
                MessageBox.Show("Error! Divide by zero!");
           
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application Calculator?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void Calculator_Load_1(object sender, EventArgs e)
        {
            obj = new Calculator1();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           

            obj.Subtract(textBox1.Text);

            textBox1.Text = "-";
            textBox1.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
           

            obj.Multiply(textBox1.Text);

            textBox1.Text = "*";
            textBox1.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
                obj.Divide(textBox1.Text);

                textBox1.Text = "/";
                textBox1.Focus();
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            obj.Clear();
            textBox1.Text = "0";
            textBox1.Focus();
        }
               
    }
}
