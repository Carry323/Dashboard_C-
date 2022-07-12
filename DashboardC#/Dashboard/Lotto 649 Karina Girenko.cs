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
    public partial class Lotto_649 : Form
    {
        public Lotto_649()
        {
            InitializeComponent();
        }

        string dir = "";
        string dirPath = @"C:\Text";
        string filePath = @"C:\Text\LottoNbrs.txt";
        FileStream Lotto649 = null;
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
            int[] arrNum = new int[7];
            int i, y;
            string tempo = "";
            for (i = 0; i < 7; i++)
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
                Lotto649 = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(Lotto649);
                textOut.WriteLine("\n 649 " + DateTime.Now.ToString() + "\t"+ textBox1.Text);
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
                Lotto649.Close();
            }
        }

        private void Lotto_649_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            byte count = 0;

            Lotto649 = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(Lotto649);

            string textToPrint = "  Karina Girenko\n";
            string For;

            while (textIn.Peek() != -1)
            {
                For = textIn.ReadLine();
              
                textToPrint += For + " ";
                count++;

                if (count == 101)
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
    }
}


