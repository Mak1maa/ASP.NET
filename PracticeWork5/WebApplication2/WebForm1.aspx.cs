using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient cl = new ServiceReference1.WebService1SoapClient();
            Label1.Text = cl.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient cl2 = new ServiceReference1.WebService1SoapClient();
            Label2.Text = cl2.AddSubtraction(Convert.ToInt32(TextBox3.Text), Convert.ToInt32(TextBox4.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient cl3 = new ServiceReference1.WebService1SoapClient();
            Label3.Text = cl3.AddDivision(Convert.ToInt32(TextBox5.Text), Convert.ToInt32(TextBox6.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient cl4 = new ServiceReference1.WebService1SoapClient();
            Label4.Text = cl4.AddMultiplication(Convert.ToInt32(TextBox7.Text), Convert.ToInt32(TextBox8.Text)).ToString();
        }
    }
}