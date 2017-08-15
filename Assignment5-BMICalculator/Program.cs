using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Shakil Hosin
 * 300922629
 * Date: August 15, 2017
 * Description: BMI CALCULATOR 
 * Version: 0.2 - designed the splash screen and finalized program. 
 */
namespace Assignment5_BMICalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static BMICalculator bmicalculator;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bmicalculator = new BMICalculator();
            Application.Run(new SplashScreen());
            Application.Run(new BMICalculator());
        }
    }
}
