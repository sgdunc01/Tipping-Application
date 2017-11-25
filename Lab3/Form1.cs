// Lab 3
// CIS 199-01/-75
// Due: 2/09/2016
// By: Spencer G. Duncan

// This program displays three tip options
// after the user enters the meal price into the 
// textbox and clicks the "Calculate tip" button. 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This class converts the string that the user enters into a decimal and then calculates and displays three different tip options
        private void calculateTipBtn_Click(object sender, EventArgs e)
        {
            const decimal SMALL_TIP = .15m; // stores the smallest percentage and cannot be changed unless interacting with the code
            const decimal MEDIUM_TIP = .18m;// stores the medium percentage and cannot be changed unless interacting with the code
            const decimal LARGE_TIP = .20m;// stores the largest percentage and cannot be changed unless interacting with the code
            
            decimal mealPrice = decimal.Parse(priceTxt.Text);// converts the user entered text to a decimal and stores the value
            
            decimal tipOne = mealPrice * SMALL_TIP;// stores the value of the lowest tip after it has been calculated
            decimal tipTwo = mealPrice * MEDIUM_TIP;// stores the value of the middle tip after it has been calculated
            decimal tipThree = mealPrice * LARGE_TIP;// stores the value of the largest tip after it has been calculated
           
            lowTipLbl.Text = tipOne.ToString("C");
            middleTipLbl.Text = tipTwo.ToString("C");
            highTipLbl.Text = tipThree.ToString("C");
        }
    }
}
