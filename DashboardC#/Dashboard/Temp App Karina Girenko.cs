using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;


namespace Dashboard
{
    public partial class Temp_App_Karina_Girenko : Form
    {
        double cel = 0, fr = 0;
        string dir = "";
        string dirPath = @"C:\Text";
        string filePath = @"C:\Text\TempConversions.txt";
        FileStream Temperature = null;

        public Temp_App_Karina_Girenko()
        {
            InitializeComponent();
        }

        private void Temp_App_Karina_Girenko_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application Convert temperature?", "Exit",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // if (button1.Enabled == false) button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte count = 0;

            Temperature = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(Temperature);

            string textToPrint = " ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                    if (textBox1.Text != "" && radioButton2.Checked == true)
                    {
                        fr = double.Parse(textBox1.Text);
                        cel = (fr - 32) * 5 / 9;


                        textBox2.Text = cel.ToString();
                        label1.Text = "F";
                        label2.Text = "C";

                    try
                    {
                        Temperature = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                        StreamWriter textOut = new StreamWriter(Temperature);
                        textOut.Write (textBox1.Text + " F = ");
                        textOut.WriteLine( textBox2.Text + " C" + "\t" + DateTime.Now.ToString() + "\n");
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

                    if (cel == 100)
                        {
                            textBox3.Text = "Water boils";
                        }
                        else if (cel == 40)
                        {
                            textBox3.Text = "Hot Bath";
                        }
                        else if (cel == 37)
                        {
                            textBox3.Text = "Body temperature";
                        }
                        else if (cel == 30)
                        {
                            textBox3.Text = "Beach weather";
                        }
                        else if (cel == 21)
                        {
                            textBox3.Text = "Room temperature";
                        }
                        else if (cel == 10)
                        {
                            textBox3.Text = "Cool day";
                        }
                        else if (cel == 0)
                        {
                            textBox3.Text = "Freezing point of water";
                        }
                        else if (cel == -18)
                        {
                            textBox3.Text = "Very Cold Day";
                        }
                        else if (cel == -40)
                        {
                            textBox3.Text = "Extremely Cold Day " +
                                "\t (and the same number!)";     //как сделать с новой строки
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

        }
    }
//}

