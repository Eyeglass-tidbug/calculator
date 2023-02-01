using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    //disclamer i don't know how to write dev()funcion in c#  so the code is a bit massy -nantawat
    public partial class Form1 : Form
    {
        string oppa = "";
        double fs_num = 0;
        double ls_num = 0;
        double Ans = 0;
        bool dot_check = false;
        public Form1()
        {
            InitializeComponent();

        }
        private void clear_Click(object sender, EventArgs e)
        {
            this.fs_num = 0;
            this.ls_num = 0;
            this.dot_check = false;
            this.ans.Text = "0";
            this.cal.Text = "";
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            this.ls_num = 0;
            this.oppa = "-";
            if (this.ans.Text != "0")
            {
                this.cal.Text = this.ans.Text + " -";
                this.fs_num = double.Parse(this.ans.Text);
                this.ans.Text = "0";
            }
            this.dot_check = false;
        }

        private void Pluse_Click(object sender, EventArgs e)
        {
            this.ls_num = 0;
            this.oppa = "+";
            if (this.ans.Text != "0")
            {
                this.cal.Text = this.ans.Text + " +";
                this.fs_num = double.Parse(this.ans.Text);
                this.ans.Text = "0";
            }
            this.dot_check = false;
        }

        private void con_Click(object sender, EventArgs e)
        {
            this.ls_num = 0;
            this.oppa = "*";
            if (this.ans.Text != "0")
            {
                this.cal.Text = this.ans.Text + " *";
                this.fs_num = double.Parse(this.ans.Text);
                this.ans.Text = "0";
            }
            this.dot_check = false;
        }

        private void han_Click(object sender, EventArgs e)
        {
            this.ls_num = 0;
            this.oppa = "/";
            if (this.ans.Text != "0")
            {
                this.cal.Text = this.ans.Text + " /";
                this.fs_num = double.Parse(this.ans.Text);
                this.ans.Text = "0";
            }
            this.dot_check = false;
        }

        private void findsolution_Click(object sender, EventArgs e)
        {
            if (this.ls_num == 0)
            {
                this.ls_num = double.Parse(this.ans.Text);
            }
            else
            {
                this.cal.Text = this.fs_num + this.oppa + this.ls_num;
                this.fs_num = double.Parse(this.ans.Text);
            }
            if (oppa == "+")
            {
                this.Ans = fs_num + ls_num;
                this.ans.Text = Ans.ToString();
            }
            else if (oppa == "-")
            {
                this.Ans = fs_num - ls_num;
                this.ans.Text = Ans.ToString();
            }
            else if (oppa == "*")
            {
                this.Ans = fs_num * ls_num;
                this.ans.Text = Ans.ToString();
            }
            else if (oppa == "/")
            {
                this.Ans = fs_num / ls_num;
                this.ans.Text = Ans.ToString();
            }
            this.dot_check = false;
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "1"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "1";
            }
            else
            { this.ans.Text += "1";}
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "2"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "2";
            }
            else
            { this.ans.Text += "2"; }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "3"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "3";
            }
            else
            { this.ans.Text += "3"; }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "4"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "4";
            }
            else
            { this.ans.Text += "4"; }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "5"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "5";
            }
            else
            { this.ans.Text += "5"; }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "6"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "6";
            }
            else
            { this.ans.Text += "6"; }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "7"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "7";
            }
            else
            { this.ans.Text += "7"; }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "8"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "8";
            }
            else
            { this.ans.Text += "8"; }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text = "9"; }
            else if (this.ls_num != 0)
            {
                this.ls_num = 0;
                this.cal.Text = "";
                this.ans.Text = "9";
            }
            else
            { this.ans.Text += "9"; }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (this.ans.Text == "0")
            { this.ans.Text += ""; }
            else
            { this.ans.Text += "0"; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (dot_check == false)
            {
                this.dot_check = true;
                this.ans.Text += ".";
            }
        }
    }
}
