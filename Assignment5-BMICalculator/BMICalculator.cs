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
 * 300922629
 * Description: BMI CALCULATOR 
 * Version: 0.7 - Displays integer as well as the the weight scale in accordance to bmi upon CalculateBMI.
 */

namespace Assignment5_BMICalculator
{
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCE VARIABLES 
        private double _result;
        private string _scale;



        //PUBLIC PROPERTIES 
        //Property to count lines in the multiline text box 
        public int numlines = 0;
        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        public string Scale
        {
            get
            {
                return this._scale;
            }
            set
            {
                this._scale = value;
            }
        }


        //CONSTRUCTORS
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method calculates the Bmi when clicked and displays the message to TxtBoxResult
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMI_Click(object sender, EventArgs e)
        {

            //Checks whether the metric or imperial button is clicked down before calculating
            if (MetricButton.Checked)
            {
                Result = Convert.ToDouble(TxtBoxWeight.Text) / (Convert.ToDouble(TxtBoxHeight.Text) * Convert.ToDouble(TxtBoxHeight.Text));
                TxtBoxResult.Text = "" + Result;

            }
            // Does the same for the imperial calculations
            if (ImperialButton.Checked)
            {
                Result = Convert.ToDouble(TxtBoxWeight.Text) * 703 / (Convert.ToDouble(TxtBoxHeight.Text) * Convert.ToDouble(TxtBoxHeight.Text));
                TxtBoxResult.Text = "" + Result;

            }
            //Checks the result calculation and updates the property Scale in accordance to underweight, normal, overweight, or obese. 

            if (Result < 18.6)
            {
                Scale = "Underweight";
            }
            if (Result > 18.6 && Result < 25)
            {
                Scale = "Normal";
            }
            if (Result >= 25 && Result < 30)
            {
                Scale = "Overweight";
            }
            if (Result >= 30)
            {
                Scale = "Obese";
            }

            TxtBoxBMIScale.Text = Scale;

        }
        /// <summary>
        /// This Displays the units that the metric calculations are to be entered in upon clicking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricButton_Click(object sender, EventArgs e)
        {
            LblMeasurement.Text = "In Metres";
            LblWMeasurement.Text = "In Kilos";
        }
        /// <summary>
        ///  This Displays the units that the imperial calculations are to be entered in upon clicking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialButton_Click(object sender, EventArgs e)
        {
            LblMeasurement.Text = "In Inches";
            LblWMeasurement.Text = "In Pounds";
        }

    }    
    }
 

