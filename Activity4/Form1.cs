using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // this code runs when the Calculate button is clicked
        private void Calculate_Click(object sender, EventArgs e)
        {
            double seconds; // this variable will store the input in seconds from the InputTextBox after it has been parsed into a numeric data type
            double result = 0; // this variable will store the result of converting the input into another unit of time
            string unit = "seconds"; // this varaible will store the unit of time to which the input has been converted
            string output; // this variable will store the result variable and the unit formatted into a single string

            if (Double.TryParse(InputTextBox.Text, out seconds)) // parses the text in the InputTextBox into a double and stores it in the result variable. If the parse is successful, a conditional statement runs to calculate the result
            {
                if (seconds >= 86400) // if the input is greater than 86400, it is divided by 86400 to yield a result in days
                {
                    unit = "days"; // sets the unit to days
                    result = seconds / 86400; // sets the result to the input divided by 86400
                }
                else if (seconds >= 3600) // if the input is greater than 3600, it is divided by 3600 to yield a result in hours
                {
                    unit = "hours"; // sets the unit to hours
                    result = seconds / 3600; // sets the result to the input divided by 3600
                }
                else if (seconds >= 60) // if the input is greater than 60, it is divided by 60 to yield a result in minutes
                {
                    unit = "minutes"; // sets the unit to minutes
                    result = seconds / 60; // sets the result to the input divided by 60
                }
                else // if the result is less than 60, no division is required and the result will be in seconds
                {
                    unit = "seconds"; // sets the unit to seconds
                    result = seconds; // sets the result to be equal to the input
                }
            }
            else // if the parse is not successful, a message box is displayed requested a numeric input. Made with help from the textbook (Gaddis, 238)
            {
                MessageBox.Show("Please input a number."); // displays a message box requesting a numeric input
            }

            output = result.ToString() + " " + unit; // formats the result and the unit into one string
            OutputLabel.Text = output; // sets the text of the OutputLabel to the formatted string
        }
    }
}

// References:
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson Education, Inc.
