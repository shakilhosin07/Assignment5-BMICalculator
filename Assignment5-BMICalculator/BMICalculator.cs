using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Shakil Hosin
 * Date: August 11, 2017
 * Description: BMI CALCULATOR 
 * Version: 0.5 - Added blank labels in the form to change in the event that metric or imperial button is clicked. 
 */

namespace Assignment5_BMICalculator
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }

        private void CalculateBMI_Click(object sender, EventArgs e)
        {
            //Checks whether the metric or imperial button is clicked down before calculating
            if (MetricButton.Checked)
            {
                double result = Convert.ToDouble(TxtBoxWeight.Text) / (Convert.ToDouble(TxtBoxHeight.Text) * Convert.ToDouble(TxtBoxHeight.Text));
                TxtBoxResult.Text = "" + result;

                if (result < 18.6)
                {
                    TxtBoxResult.Text = "Underweight";
                }
                if (result > 18.6 && result < 25)
                {
                    TxtBoxResult.Text = "Normal";
                }
                if (result >= 25 && result < 30)
                {
                    TxtBoxResult.Text = "Overweight";
                }
                if (result >= 30)
                {
                    TxtBoxResult.Text = "Obese";
                }
            }
            // Does the same for the imperial calculations
            if (ImperialButton.Checked)
            {
                double result = Convert.ToDouble(TxtBoxWeight.Text) * 703 / (Convert.ToDouble(TxtBoxHeight.Text) * Convert.ToDouble(TxtBoxHeight.Text));
                TxtBoxResult.Text = "" + result;

                if (result < 18.6)
                {
                   TxtBoxResult.Text = "Underweight";
                }
                if (result > 18.6 && result < 25)
                {
                   TxtBoxResult.Text = "Normal";
                }
                if (result >= 25 && result < 30)
                {
                   TxtBoxResult.Text = "Overweight";
                }
                if (result >= 30)
                {
                    TxtBoxResult.Text = "Obese";
                }
            }
        }

        private void MetricButton_Click(object sender, EventArgs e)
        {
            LblMeasurement.Text = "In Metres";
            LblWMeasurement.Text = "In Kilos";
        }

        private void ImperialButton_Click(object sender, EventArgs e)
        {
            LblMeasurement.Text = "In Inches";
            LblWMeasurement.Text = "In Pounds";
        }
    }
}
