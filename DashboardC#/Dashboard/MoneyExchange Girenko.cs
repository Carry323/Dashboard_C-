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
        public partial class MoneyExchange_Girenko : Form

    {
        public class MoneyExchange
        {
           

            private double currency;

            public double Currency
            {
                get
                {
                    return currency;
                }
                set
                {
                    currency = value;
                }
            }

            public MoneyExchange() { }

            public MoneyExchange( double val)
            {
                this.Currency = currency;
            }


            //CAD
            public double CAD_USD()
            {
                return Currency * 0.79;
            }
            public double CAD_EUR()
            {
                return Currency * 0.66;
            }
            public double CAD_GBP()
            {
                return Currency * 0.57;
            }
            public double CAD_ILS()
            {
                return Currency * 2.64;
            }

            //USD
            public double USD_CAD()
            {
                return Currency * 1.25;
            }
            public double USD_EUR()
            {
                return Currency * 0.86;
            }
            public double USD_GBP()
            {
                return Currency * 0.71;
            }
            public double USD_ILS()
            {
                return Currency * 3.35;
            }

            //EUR
            public double EUR_CAD()
            {
                return Currency * 1.51;
            }
            public double EUR_USD()
            {
                return Currency * 1.2;
            }
            public double EUR_GBP()
            {
                return Currency * 0.82;
            }
            public double EUR_ILS()
            {
                return Currency * 3.96;
            }

            //GBP
            public double GBP_CAD()
            {
                return Currency * 1.74;
            }
            public double GBP_USD()
            {
                return Currency * 1.39;
            }
            public double GBP_EUR()
            {
                return Currency * 1.16;
            }
            public double GBP_ILS()
            {
                return Currency * 4.63;
            }

            //ILS
            public double ILS_CAD()
            {
                return Currency * 0.38;
            }
            public double ILS_USD()
            {
                return Currency * 0.3;
            }
            public double ILS_EUR()
            {
                return Currency * 0.25;
            }
            public double ILS_GBP()
            {
                return Currency * 0.22;
            }

        }

        string dir = "";
        string dirPath = @"C:\Text";
        string filePath = @"C:\Text\MoneyConversions.txt";
        FileStream MoneyExc = null;
        private void MoneyExchange_Girenko_Load(object sender, EventArgs e)
        {
            obj = new MoneyExchange();
        }

        public MoneyExchange_Girenko()
        {
            InitializeComponent();
        }


        MoneyExchange obj;

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application Money Exchange?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    obj.Currency = Convert.ToDouble(textBox1.Text);
                    if (radioButton7.Checked == true)
                    {
                        double result = obj.CAD_USD();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " CAD = ");
                            textOut.WriteLine(textBox2.Text + " USD" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton8.Checked == true)
                    {
                        double result = obj.CAD_EUR();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " CAD = ");
                            textOut.WriteLine(textBox2.Text + " EUR" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }


                    else if (radioButton9.Checked == true)
                    {
                        double result = obj.CAD_GBP();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " CAD = ");
                            textOut.WriteLine(textBox2.Text + " GBP" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton10.Checked == true)
                    {
                        double result = obj.CAD_ILS();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " CAD = ");
                            textOut.WriteLine(textBox2.Text + " ILS" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton6.Checked == true)
                    {
                        MessageBox.Show("You cannot use same currency", "Warning",
                        MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }

            //USD
            else if (radioButton2.Checked == true)
            {
                try
                {
                    obj.Currency = Convert.ToDouble(textBox1.Text);
                    if (radioButton6.Checked == true)
                    {
                        double result = obj.USD_CAD();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " USD = ");
                            textOut.WriteLine(textBox2.Text + " CAD" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton8.Checked == true)
                    {
                        double result = obj.USD_EUR();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " USD = ");
                            textOut.WriteLine(textBox2.Text + " EUR" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }


                    else if (radioButton9.Checked == true)
                    {
                        double result = obj.USD_GBP();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " USD = ");
                            textOut.WriteLine(textBox2.Text + " GBP" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton10.Checked == true)
                    {
                        double result = obj.USD_ILS();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " USD = ");
                            textOut.WriteLine(textBox2.Text + " ILS" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton7.Checked == true)
                    {
                        MessageBox.Show("You cannot use same currency", "Warning",
                        MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }

            //EUR
            else if (radioButton3.Checked == true)
            {
                try
                {
                    obj.Currency = Convert.ToDouble(textBox1.Text);
                    if (radioButton6.Checked == true)
                    {
                        double result = obj.EUR_CAD();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " EUR = ");
                            textOut.WriteLine(textBox2.Text + " CAD" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton7.Checked == true)
                    {
                        double result = obj.EUR_USD();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " EUR = ");
                            textOut.WriteLine(textBox2.Text + " USD" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }


                    else if (radioButton9.Checked == true)
                    {
                        double result = obj.EUR_GBP();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " EUR = ");
                            textOut.WriteLine(textBox2.Text + " GBP" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton10.Checked == true)
                    {
                        double result = obj.EUR_ILS();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " EUR = ");
                            textOut.WriteLine(textBox2.Text + " ILS" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton8.Checked == true)
                    {
                        MessageBox.Show("You cannot use same currency", "Warning",
                        MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }

            //GBP
            else if (radioButton4.Checked == true)
            {
                try
                {
                    obj.Currency = Convert.ToDouble(textBox1.Text);
                    if (radioButton6.Checked == true)
                    {
                        double result = obj.GBP_CAD();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " GBP = ");
                            textOut.WriteLine(textBox2.Text + " CAD" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton7.Checked == true)
                    {
                        double result = obj.GBP_USD();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " GBP = ");
                            textOut.WriteLine(textBox2.Text + " USD" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }


                    else if (radioButton8.Checked == true)
                    {
                        double result = obj.GBP_EUR();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " GBP = ");
                            textOut.WriteLine(textBox2.Text + " EUR" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton10.Checked == true)
                    {
                        double result = obj.GBP_ILS();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " GBP = ");
                            textOut.WriteLine(textBox2.Text + " ILS" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton9.Checked == true)
                    {
                        MessageBox.Show("You cannot use same currency", "Warning",
                        MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }

            //ILS
            else if (radioButton5.Checked == true)
            {
                try
                {
                    obj.Currency = Convert.ToDouble(textBox1.Text);
                    if (radioButton6.Checked == true)
                    {
                        double result = obj.ILS_CAD();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " ILS = ");
                            textOut.WriteLine(textBox2.Text + " CAD" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton7.Checked == true)
                    {
                        double result = obj.ILS_USD();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " ILS = ");
                            textOut.WriteLine(textBox2.Text + " USD" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }


                    else if (radioButton8.Checked == true)
                    {
                        double result = obj.ILS_EUR();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " ILS = ");
                            textOut.WriteLine(textBox2.Text + " EUR" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton9.Checked == true)
                    {
                        double result = obj.ILS_GBP();
                        textBox2.Text = result.ToString();
                        try
                        {
                            MoneyExc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(MoneyExc);
                            textOut.Write(textBox1.Text + " ILS = ");
                            textOut.WriteLine(textBox2.Text + " GBP" + "\t" + DateTime.Now.ToString() + "\n");
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
                            MoneyExc.Close();
                        }
                    }

                    else if (radioButton10.Checked == true)
                    {
                        MessageBox.Show("You cannot use same currency", "Warning",
                        MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
                
            }
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoneyExchange_Girenko_Load_1(object sender, EventArgs e)
        {
            obj = new MoneyExchange();

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            byte count = 0;

            MoneyExc = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(MoneyExc);

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
    }
}
