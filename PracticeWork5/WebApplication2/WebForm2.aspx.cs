using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet Source = (DataSet)Cache["MyCache"];
            if (Source == null)
            {
                ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
                Source = client.GetCustomers();
                Cache["MyCache"] = Source;
                Label1.Text = "DATASET CREATED FROM TABLE";
            }
            else
            {
                Label1.Text = "DATASET RETRIEVED FROM TABLE";
            }
            GridView1.DataSource = Source;
            GridView1.DataBind();
        }
    }
}