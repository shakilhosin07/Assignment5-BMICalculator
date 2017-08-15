using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_BMICalculator
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        //PUBLIC PROPERTY
        public BMICalculator BMICALCULATOR1
        {
            get
            {
                
               return Program.bmicalculator;
            }
            
        }
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.BMICALCULATOR1.Show();
            this.Hide();
            SplashScreenTimer.Enabled = false;
        }

    }
}
