﻿using System;
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
        //PRIVATE INSTANCE VARIABLES 
        private double _result;




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
                _result = Convert.ToDouble(TxtBoxWeight.Text) / (Convert.ToDouble(TxtBoxHeight.Text) * Convert.ToDouble(TxtBoxHeight.Text));
                TxtBoxResult.Text = "" + _result;

            }
            // Does the same for the imperial calculations
            if (ImperialButton.Checked)
            {
               _result = Convert.ToDouble(TxtBoxWeight.Text) * 703 / (Convert.ToDouble(TxtBoxHeight.Text) * Convert.ToDouble(TxtBoxHeight.Text));
                TxtBoxResult.Text = "" + _result;

            }
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

        private void TxtBoxBMIScale_TextChanged(object sender, EventArgs e)
        {
            numlines = TxtBoxBMIScale.Lines.Count();
        }
    }
}
