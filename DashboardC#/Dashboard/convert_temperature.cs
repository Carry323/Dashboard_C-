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
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Dashboard
{
    public partial class convert_temperature : Form
    {
        double cel = 0, fr = 0;
        string dir = "";
        string dirPath = @"C:\Text";
        string filePath = @"C:\Text\TempConversions.txt";
        FileStream Temperature = null;

        public convert_temperature()
        {
            InitializeComponent();
        }

        //   Temperature obj;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                {
                    try
                    {

                        textBox1.Enabled = true;
                        textBox2.Enabled = false;


                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.Message);
                        textBox1.Focus();
                    }
                }
            }
        }

        private void convert_temperature_Load(object sender, EventArgs e)
        {
        
            label2.Text = "";
            label4.Text = "";

            dir = @"C:\Text";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                MessageBox.Show("Folder has been created");
            }
            else
            {
                MessageBox.Show("Folder is already created");
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                {
                    try
                    {
                        Temp_App_Karina_Girenko obj = new Temp_App_Karina_Girenko();
                        obj.ShowDialog();

                        textBox1.Enabled = false;
                        textBox2.Enabled = true;

                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.Message);
                        textBox1.Focus();
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && radioButton2.Checked == true)
                {
                    cel = double.Parse(textBox1.Text);
                    fr = (cel * 9 / 5 )+ 32;

                    textBox2.Text = fr.ToString();
                    label2.Text = "C";
                    label4.Text = "F";
                    try
                    {
                        Temperature = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                        StreamWriter textOut = new StreamWriter(Temperature);
                        textOut.Write(textBox1.Text + " C = ");
                        textOut.WriteLine(textBox2.Text + " F" + "\t" + DateTime.Now.ToString() + "\n");
                        textOut.Close();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show(filePath + " not found.", "File Not Found");
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show(dirPath + " not found.", "Directory Not Found");
                    }
                    catch (IOException ex)
                    { MessageBox.Show(ex.Message, "IO Exception"); }
                    finally
                    {
                        Temperature.Close();
                    }

                    if (fr == 212)
                    { textBox3.Text = "Water boils";
                    }
                    else if (fr == 104)
                    {
                        textBox3.Text = "Hot Bath";
                    }
                    else if (fr == 98.6)
                    {
                        textBox3.Text = "Body temperature";
                    }
                    else if (fr == 86)
                    {
                        textBox3.Text = "Beach weather";
                    }
                    else if (fr == 70)
                    {
                        textBox3.Text = "Room temperature";
                    }
                    else if (fr == 50)
                    {
                        textBox3.Text = "Cool day";
                    }
                    else if (fr == 32)
                    {
                        textBox3.Text = "Freezing point of water";
                    }
                    else if (fr == 0)
                    {
                        textBox3.Text = "Very Cold Day";
                    }
                    else if (fr == -40)
                    {
                        textBox3.Text = "Extremely Cold Day \n (and the same number!)";     //как сделать с новой строки?// bold are exact?
                    }
                    else
                    {
                        textBox3.Text = "";
                    }

                }
                
            }
             catch (Exception)
            {
               MessageBox.Show("Please enter a number");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte count = 0;

            Temperature = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(Temperature);

            string textToPrint = "\n ";
            string For, Cel;

            while (textIn.Peek() != -1)
            {
                For = textIn.ReadLine();
                Cel = textIn.ReadLine();
                textToPrint += For + "\t" + Cel + "\n";
                count++;

                if (count == 21)
                {
                    MessageBox.Show(textToPrint);
                    count = 0;
                    textToPrint = "";

                }
            }
            if (count != 0)
                MessageBox.Show(textToPrint);
            textIn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application Convert temperature?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        
    }
}