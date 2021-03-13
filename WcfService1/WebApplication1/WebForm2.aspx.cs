using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            GridView1.DataSource = client.GetCustomers();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            GridViewRow row = GridView1.SelectedRow;
            int id = Convert.ToInt32(row.Cells[2].Text);
            GridView2.DataSource = client.GetOrders(id);
            GridView2.DataBind();
        }
    }
}