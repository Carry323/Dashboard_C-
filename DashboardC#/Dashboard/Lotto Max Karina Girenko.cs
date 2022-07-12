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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string dir = "";
        string dirPath = @"C:\Text";
        string filePath = @"C:\Text\LottoNbrs.txt";
        FileStream LottoMax = null;
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the form?", "Exit",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            { this.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //   int randomNumber = 0; // random.Next(1, 9);
            int[] arrNum = new int[8];
            int i, y;
            //int index = 0;
            //bool found;
            string tempo = "";

            //while (index != 8)
            //{
            //    found = false;
            //    y = random.Next();

            //    for (i = 0; i < arrNum[i]; i++)
            //    {
            //        if (arrNum[i] == y)
            //        { found = true; break; }
            //        if (!found) { arrNum[index] = y; index++; };

            //        tempo += "" + arrNum[i].ToString() + " \n";
            //    }

            //}

            for (i = 0; i < 8; i++)
            {
                arrNum[i] = random.Next(1, 49);

                for (y = 0; y < i; ++y)
                {
                    if (i == y)
                    {
                        arrNum[i] = random.Next(1, 49);
                        break;
                        // continue;
                    }
                    if (arrNum[i] == arrNum[y])
                    {
                        arrNum[i] = random.Next(1, 49);
                        y = i;
                    }
                }
                tempo += "" + arrNum[i].ToString() + " \n";
            }

            textBox1.Text = tempo;
                tempo = "";

            try
            {
                LottoMax = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(LottoMax);


                textOut.WriteLine("\n MAX " + DateTime.Now.ToString() + "\t" + textBox1.Text + "\n");
                textOut.Close();


               // byte count = 0;

               //// StreamWriter writeToFile = new StreamWriter(pathNuturalNumbers, false, Encoding.UTF8);
               // for (count = 0; count <= 8; count++)
               // {
               //     if (count == 8)
               //     {
               //         textOut.Write("\n MAX " + DateTime.Now.ToString() + "\t" + textBox1.Text + "\n");
               //         break;
               //     }
               //     textOut.Write("\n MAX " + DateTime.Now.ToString() + "\t" + textBox1.Text + "\n");
               // }
               // textOut.Close();


                //    textOut.Write(DateTime.Now.ToString());
                //for (int x = 0; x < 8; x++)
                //{
                //    // Write format string to file.
                //    textOut.Write("{0} " + textBox1.Text);
                //}

                //textOut.Write("\n MAX " + DateTime.Now.ToString() + "\t" + textBox1.Text + "\n");
                //textOut.Close();

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
                LottoMax.Close();
            }
            }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            byte count = 0;

            LottoMax = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(LottoMax);

            string textToPrint = "  Karina Girenko\n";
            string For;



            //if (count <= 7)

            //{
            //    For = textIn.ReadLine();

            //    textToPrint += For + ", ";

            //}
            //if (count == 8)


            //{
            //    For = textIn.ReadLine();

            //    textToPrint += "Extra " + For;

            //}


             while (textIn.Peek() != -1)
            {
                For = textIn.ReadLine();

                textToPrint += For + ", ";
                count++;
                

                if (count == 101)
                {
                    MessageBox.Show(textToPrint);
                    count = 0;
                    textToPrint = "";
                   
                }

            }
            
           

            if (count != 0)
            {
                MessageBox.Show(textToPrint);
                textIn.Close();
            }
        }
    }
}
