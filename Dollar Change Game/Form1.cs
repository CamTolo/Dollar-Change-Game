using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollar_Change_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //create variables for caluclation
            double pennies, dime, nickel, quarter, totalValue;
 
            //Get user input && Create calculations
            pennies = double.Parse(penniesTextBox.Text) * 0.01;
            dime = double.Parse(dimesTextBox.Text) * 0.10;
            nickel = double.Parse(nickelsTextBox.Text) * 0.05;
            quarter = double.Parse(quartersTextBox.Text) * 0.25;

            totalValue = pennies + dime + nickel + quarter;
            
            if(totalValue == 1.00)
            {
                changeLabel.Text = "Congratulations Winner! \n" +
                    "You have 1 Dollar!!";
            }
            else if(totalValue <= 1.00)
            {
                changeLabel.Text = "You entered an amount\n " +
                    "LESS then 1 dollar";
            }
            else if (totalValue >= 1.00)
            {
                changeLabel.Text = "You entered an amount\n" +
                    " ABOVE 1 dollar";
            }
            else
            {
                changeLabel.Text = "Please fill out the above sections";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //This button clears all entries off program
            penniesTextBox.Clear();
            dimesTextBox.Clear();
            nickelsTextBox.Clear();
            quartersTextBox.Clear();
            changeLabel.Text = "";
        }
    }
}
