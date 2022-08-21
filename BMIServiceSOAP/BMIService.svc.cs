using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BMIServiceSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class BMIService : IBMIService
    {
        public double myBMI(int height, int weight)
        {
            double num = weight * 703 / (height * height);
            return num;
        }

        public BMI myHealth(int height, int weight)
        {
            BMI res = new BMI();
            double num = weight * 703 / (height * height);
            res.bmi = num;

            string r = null;
            if (num < 18)
            {
                r = "You are underweight if BMI is < 18";
            }
            else if (num >= 18 && num < 25)
            {
                r = "You are normal if BMI is >=18 and < 25";
            }
            else if (num >= 25 && num <= 30)
            {
                r = "You are pre-obese if BMI is between 25 and 30";
            }
            else if (num > 30)
            {
                r = "You are obese if BMI is greater than 30";
            }
            else
            { r = "Invalid input"; }
            res.risk = r;

            string[] arr = {"https://www.cdc.gov/healthyweight/assessing/bmi/index.html",
                            "https://www.nhlbi.nih.gov/health/educational/lose_wt/index.htm",
                            "https://www.ucsfhealth.org/education/body_mass_index_tool/"};
            res.more = arr;
            return res;
        }
    }
}
