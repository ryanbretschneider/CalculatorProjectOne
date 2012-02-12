using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorProjectOne
{
   

    public partial class Form1 : Form
    { 
        private double activenum = 0;
        private double activetemp = 0;
       // private double currentans = 0;
        public Boolean operate = false;
        private int operation = 0;
        String temp = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "7";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "7";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "8";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "8";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "9";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "9";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "4";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "4";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "5";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "5";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "6";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "6";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "1";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "1";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "2";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "2";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "3";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "3";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            if (operate == false)
            {
                temp = activenum.ToString();
                temp = temp + "0";
                activenum = Convert.ToDouble(temp);
                activebox.Text = activenum.ToString();
            }
            else
            {
                temp = activetemp.ToString();
                temp = temp + "0";
                activetemp = Convert.ToDouble(temp);
                activebox.Text = activetemp.ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (operate == true)
            {
                double ans = 0;
                if (operation == 1)
                {
                    ans = activenum + activetemp;
                }
                else if (operation == 2)
                {
                    ans = activenum - activetemp;
                }
                else if (operation == 3)
                {
                    ans = activenum * activetemp;
                }
                else if (operation == 4)
                {
                    ans = activenum / activetemp;
                }
                activenum = ans;
                activetemp = 0;
                activebox.Text = activenum.ToString();
            }
            else
            {
                operate = true;
               
            }
            operation = 1;
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            if (operate == true) {
                double ans = 0;
                if (operation == 1)
                {
                    ans = activenum + activetemp;
                }
                else if (operation == 2)
                {
                    ans = activenum - activetemp;
                }
                else if (operation == 3)
                {
                    ans = activenum * activetemp;
                }
                else if (operation == 4)
                {
                    ans = activenum / activetemp;
                }
                activenum = ans;
                activetemp = 0;
                activebox.Text = activenum.ToString();
            }
            else {

            operate = true;
            
            }
            operation = 2;
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            if (operate == true)
            {
                double ans = 0;
                if (operation == 1)
                {
                    ans = activenum + activetemp;
                }
                else if (operation == 2)
                {
                    ans = activenum - activetemp;
                }
                else if (operation == 3)
                {
                    ans = activenum * activetemp;
                }
                else if (operation == 4)
                {
                    ans = activenum / activetemp;
                }
                activenum = ans;
                activetemp = 0;
                activebox.Text = activenum.ToString();
            }
            else
            {
                operate = true;
                
            }
            operation = 3;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (operate == true)
            {
                double ans = 0;
                if (operation == 1)
                {
                    ans = activenum + activetemp;
                }
                else if (operation == 2)
                {
                    ans = activenum - activetemp;
                }
                else if (operation == 3)
                {
                    ans = activenum * activetemp;
                }
                else if (operation == 4)
                {
                    ans = activenum / activetemp;
                }
                activenum = ans;
                activetemp = 0;
                activebox.Text = activenum.ToString();
            }
            else
            {
                operate = true;
                
            }
            operation = 4;
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            //do the correct operation
            double ans = 0;
            if (operation == 1){
            ans = activenum + activetemp;
        }
            else if(operation ==2){
                ans = activenum - activetemp;
            }
            else if (operation == 3)
            {
                ans = activenum * activetemp;
            }
            else if (operation == 4)
            {
                ans = activenum / activetemp;
            }
            if (operate == false)
            {
            }
            activenum = ans;
            //currentans = ans;
            activebox.Text = activenum.ToString();
            ans = 0;
            operate = false;
            operation = 0;
            activetemp = 0;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            activenum = 0;
            activetemp = 0;
            operate = false;
            operation = 0;
            activebox.Text = "0.0";
        }

    }
}
