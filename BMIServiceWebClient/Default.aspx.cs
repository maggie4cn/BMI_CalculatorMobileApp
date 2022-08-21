using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMIServiceWebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            ServiceReference1.BMIServiceClient myClient = new ServiceReference1.BMIServiceClient("BasicHttpBinding_IBMIService");
            int x = Int32.Parse(TextBox1.Text);
            int y = Int32.Parse(TextBox2.Text);
            double resBMI = myClient.myBMI(x, y);
            Literal5.Text = resBMI.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.BMIServiceClient myClient = new ServiceReference1.BMIServiceClient("BasicHttpBinding_IBMIService");

            int x = Int32.Parse(TextBox1.Text);
            int y = Int32.Parse(TextBox2.Text);
            ServiceReference1.BMI resHealth = myClient.myHealth(x, y);


            String infor = "For more information, please visit:";
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < resHealth.more.Length; i++)
            {
                sb.Append(resHealth.more[i] + "<br/>");
            }

            if (resHealth.bmi < 18)
            { Literal6.Text = "<font color = #0000FF>" + resHealth.risk.ToString() + "</font >" + "<br/>"; }
            else if (resHealth.bmi >= 18 && resHealth.bmi < 25)
            { Literal6.Text = "<font color = #008000>" + resHealth.risk.ToString() + "</font >" + "<br/>"; }
            else if (resHealth.bmi >= 25 && resHealth.bmi <= 30)
            { Literal6.Text = "<font color = #800080>" + resHealth.risk.ToString() + "</font >" + "<br/>"; }
            else if (resHealth.bmi > 30)
            { Literal6.Text = "<font color = #FF0000>" + resHealth.risk.ToString() + "</font >" + "<br/>"; }
            else
            { Literal6.Text = resHealth.risk.ToString() + "<br/>"; }

            Literal7.Text = infor + "<br/>" + sb.ToString();
        }
    }
}