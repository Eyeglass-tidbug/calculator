using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        //kenmy = operator var 1/2/3/4
        double kenmy = 7;
        //double countcom = 0;
        bool dotchcck = false;
        //new number
        bool newnum = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //start + - * /
        //+
        private void Ans_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double input2 = double.Parse(this.Ans.Text);
            double result = 0;
            //set to op does nothing when no op
            if (kenmy == 1)
            {
                this.Ans.Text = (input1 + input2).ToString();
                //this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
            else if (kenmy == 2)
            {
                result = (input1 - input2);
                this.Ans.Text =  result.ToString();
            }
            else if (kenmy == 3)
            {
                result = (input1 * input2);
                this.Ans.Text = result.ToString();

            }
            else if (kenmy == 4)
            {
                result = (input1 / input2);
                this.Ans.Text = result.ToString();

            }
           else if (input2 == null)
            {
                this.Ans.Text = this.Ans.Text;
            }
            //check if dot or not dot = 0.00 no dot = 0
            if (dotchcck == true )
            {
                this.Ans.Text = string.Format("{0:N2}", double.Parse(this.Ans.Text));
            }
            else //(dotchcck== false)
            {
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
            this.newnum = true;

        }

        private void ONE_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
                //to clear number
                //this.kenmy = 0;
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "1";

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "1";
            }
            else
            //continue when = does not press yet
            {
                this.Ans.Text += "1";
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
                
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
                
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "2";

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "2";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "2";
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
               
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "3";

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "3";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "3";
            }
            this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
                
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "4";

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "4";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "4";
            }
            this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
        
    }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
                
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "5";

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "5";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "5";
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
                
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "6";
              

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "6";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "6";
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
                
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "7";
                //this.kenmy = 1;

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "7";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "7";
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
                
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "8";

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "8";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "8";
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (this.newnum == true)
            {
                this.Ans.Text = "";
                this.newnum = false;
                this.Ans.Text = this.Ans.Text + "9";

            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "9";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "9";
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.kenmy == -1)
            {
                this.kenmy = 0;
                this.Ans.Text = "";
                this.Ans.Text = this.Ans.Text + "0";
            }
            else if (this.dotchcck == true)
            {
                this.Ans.Text += "0";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "0";
                this.Ans.Text = string.Format("{0:N0}", double.Parse(this.Ans.Text));
            }
        }
        //dot btton
        private void dotbut_Click(object sender, EventArgs e)
        {
            if (this.dotchcck == false)
            {
                this.dotchcck = true;
                this.Ans.Text = this.Ans.Text + ".";
            }
            else
            {
                this.Ans.Text = this.Ans.Text + "";
            }
        }

        private void lob_Click_1(object sender, EventArgs e)
        {
            //lob
            this.input1 = double.Parse(this.Ans.Text);
            kenmy = 2;
            newnum = true;
            this.Prebox.Text = this.Ans.Text + " -";

        }

        private void bok_Click_1(object sender, EventArgs e)
        {
            //bob
            this.input1 = double.Parse(this.Ans.Text);
            kenmy = 1;
            newnum = true;
            //this.Ans.Text = "0";
            this.Prebox.Text = this.Ans.Text + " +"  ;
        }

        private void con_Click_1(object sender, EventArgs e)
        {
            //con
            this.input1 = double.Parse(this.Ans.Text);
            kenmy = 3;
            newnum = true;
            this.Prebox.Text = this.Ans.Text + " x";
        }

        private void han_Click_1(object sender, EventArgs e)
        {
            //han
            this.input1 = double.Parse(this.Ans.Text);
            kenmy = 4;
            newnum = true;
            this.Prebox.Text = this.Ans.Text + " /";
        }
        // clear button
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Ans.Text = "0";
            this.Prebox.Text = "";
            this.newnum= false;
            //this.countcom = 0;
            this.kenmy = 7;
            this.dotchcck = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
