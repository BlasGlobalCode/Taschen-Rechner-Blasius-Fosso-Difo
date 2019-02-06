using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taschenrechner_Blasius
{
    public partial class Calculatrice : Form
    {
        
        public Calculatrice()
        {
            InitializeComponent();
        }
        public enum MemoryStatEnum
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        double FirstNumber;
        string Operation;
        private void btnnull_Click(object sender, EventArgs e)
        {
            {
                txteingabe.Text = txteingabe.Text + "0";
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            
            FirstNumber = Convert.ToDouble(txteingabe.Text);
            txteingabe.Text = "0";
            Operation = "+";
        }

        private void btneins_Click(object sender, EventArgs e)
        {
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "1";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "1";
            }
        }

        private void btnzwei_Click(object sender, EventArgs e)
        {
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "2";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "2";
            }
        }

        private void btndrei_Click(object sender, EventArgs e)
        {
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "3";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "3";
            }
        }

        private void btnvier_Click(object sender, EventArgs e)
        {
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "4";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "4";
            }
        }

        private void btnfuenf_Click(object sender, EventArgs e)
        {
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "5";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "5";
            }
        }

        private void btnsechs_Click(object sender, EventArgs e)
        {
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "6";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "6";
            }
        }

        private void btnsieben_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "7";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "7";
            }
        }

        private void btnacht_Click(object sender, EventArgs e)
        {
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "8";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "8";
            }
        }

        private void btnneun_Click(object sender, EventArgs e)
        {
            if (txteingabe.Text == "0" && txteingabe.Text != null)
            {
                txteingabe.Text = "9";
            }
            else
            {
                txteingabe.Text = txteingabe.Text + "9";
            }
        }

        private void btnpunkt_Click(object sender, EventArgs e)
        {
            txteingabe.Text = txteingabe.Text + ".";

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txteingabe.Text);
            txteingabe.Text = "0";
            Operation = "-";
        }

        private void btnmal_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txteingabe.Text);
            txteingabe.Text = "0";
            Operation = "*";
        }

        private void btngeteilt_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txteingabe.Text);
            txteingabe.Text = "0";
            Operation = "/";
        }

        private void btngleich_Click(object sender, EventArgs e)
            {

                
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
        }

        private void txteingabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngleich_Click_1(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            SecondNumber = Convert.ToDouble(txteingabe.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txteingabe.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txteingabe.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txteingabe.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txteingabe.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txteingabe.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void btnmal_Click_1(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txteingabe.Text);
            txteingabe.Text = "0";
            Operation = "*";
        }

        private void btngeteilt_Click_1(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txteingabe.Text);
            txteingabe.Text = "0";
            Operation = "/";
        }

        private void btnminus_Click_1(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txteingabe.Text);
            txteingabe.Text = "0";
            Operation = "-";
        }

        private void btndelete_Click_2(object sender, EventArgs e)
        {
            txteingabe.Text = "";
        }

        
    }
}

