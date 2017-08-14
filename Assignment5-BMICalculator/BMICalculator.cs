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
 * Date: August 14, 2017
 * 300922629
 * Description: BMI CALCULATOR 
 * Version: 0.8 - Added a try and catch to see if result = 0;
 */

namespace Assignment5_BMICalculator
{
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCE VARIABLES 
        private double _result;
        private string _scale;



        //PUBLIC PROPERTIES 
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

        public string BmiScale
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
            BMIProgressBar.Value = 0;
            
            //Checks whether the metric or imperial button is clicked down before calculating
            if (MetricButton.Checked)
            {
                try
                {
                    Result = Convert.ToDouble(TxtBoxWeight.Text) / (Convert.ToDouble(TxtBoxHeight.Text) * Convert.ToDouble(TxtBoxHeight.Text));
                    TxtBoxResult.Text = "" + Result;
                }
             catch
                {

                    Result = 0;
                    

                    TxtBoxResult.Text = "Please use a numerical value!";
                    
                }

            }
            // Does the same for the imperial calculations
            if (ImperialButton.Checked)
            {
                try
                {
                    Result = Convert.ToDouble(TxtBoxWeight.Text) * 703 / (Convert.ToDouble(TxtBoxHeight.Text) * Convert.ToDouble(TxtBoxHeight.Text));
                    TxtBoxResult.Text = "" + Result;
                }
                catch
                {
                    Result = 0;
                    TxtBoxResult.Text = "Please use a numerical value!";
                }
                

            }
            //Checks the result calculation and updates the property Scale in accordance to underweight, normal, overweight, or obese. 
            /// If no value is entered, property "Scale, will return "Numbers only!";
            if (Result == 0)
            {
                BmiScale = "Numbers only!";
            }
            else if (Result < 18.6)
            {
                BmiScale = "Underweight";
                BMIProgressBar.Value = 8;
            }
           else if (Result > 18.6 && Result < 25)
            {
                BmiScale = "Normal";
                BMIProgressBar.Value = 15;
            }
           else if (Result >= 25 && Result < 30)
            {
                BmiScale = "Overweight";
                BMIProgressBar.Value = 23;
            }
            else if (Result >= 30)
            {
                BmiScale = "Obese";
                BMIProgressBar.Value = BMIProgressBar.Maximum;
            }

            TxtBoxBMIScale.Text = BmiScale;

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
 

