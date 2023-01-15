using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Student student0 = new Student("Nano",1993);
            //Student student1 = new Student("Nona",1992);

            //AgeTextbox.Text = student0.myage().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            NameTextbox.Text = ""; StudenID.Text = "";
            branchTextbox.Text = ""; heightTextbox.Text = "";
            gradeTextbox.Text = "";  BirthyearTextbox.Text = "";

            string stname = this.NameTextbox.Text;
            string stid = this.StudenID.Text;
            string stheight = this.heightTextbox.Text;
            string stbranch = this.branchTextbox.Text;
            //
            string stbirthyear = this.BirthyearTextbox.Text; //int cyear = Int32.Parse(Stbirthyear);
            string stgrade = this.gradeTextbox.Text; //float cgrade = Int32.Parse(stgrade);


            //Student student = new Student(stname, stid, cyear, stheight, cgrade, stbranch);
            //this._student.add()
            //public Student(string name, string id, int birthyear, string height, float grade, string branch) { }
        }
    }
}
