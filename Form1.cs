using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fr_kalk
{
    public partial class Form1 : Form
    {
       
        double startnum = 0;
        bool newnum = false;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double endnum;
            double wynik = 0;

            if (double.TryParse(txtDisplay.Text, out endnum))
            {
                switch (operation)
                {
                    case "+":
                        wynik = startnum + endnum;
                        break;
                    case "-":
                        wynik = startnum - endnum;
                        break;
                    case "*":
                        wynik = startnum * endnum;
                        break;
                    case "/":
                        if (endnum != 0)
                            wynik = startnum / endnum;
                        else
                        {
                            MessageBox.Show("Nie dziel przez zero!");
                            return;
                        }
                        break;
                }

                txtDisplay.Text = wynik.ToString();
                newnum = true;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

                
            }
            txtDisplay.Text += btn.Text;

        }

        private void two_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

               
            }
            txtDisplay.Text += btn.Text;

        }

        private void three_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

                
            }
            txtDisplay.Text += btn.Text;

        }

        private void four_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

                
            }
            txtDisplay.Text += btn.Text;

        }

        private void five_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

               
            }

            txtDisplay.Text += btn.Text;

        }

        private void six_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

                
            }
            txtDisplay.Text += btn.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

               
            }
            txtDisplay.Text += btn.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

                
            }
            txtDisplay.Text += btn.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

               
            }
            txtDisplay.Text += btn.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newnum)
            {
                txtDisplay.Text = "";
                newnum = false;

                
            }
            txtDisplay.Text += btn.Text;
        }

        private void div_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(txtDisplay.Text, out startnum))
            {
                operation = btn.Text;
                newnum = true;
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(txtDisplay.Text, out startnum))
            {
                operation = btn.Text;
                newnum = true;
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(txtDisplay.Text, out startnum))
            {
                operation = btn.Text;
                newnum = true;
            }
        }

        private void plu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(txtDisplay.Text, out startnum))
            {
                operation = btn.Text;
                newnum = true;
            }
        }
    }
}
