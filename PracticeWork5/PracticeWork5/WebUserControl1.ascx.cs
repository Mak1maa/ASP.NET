using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWork5
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string myText
        {
            get { return TextBox1.Text; }
            set { TextBox1.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text));
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text));
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox2.Text));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text));
        }
    }
}