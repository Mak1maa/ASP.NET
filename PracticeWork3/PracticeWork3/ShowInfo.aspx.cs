﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWork3
{
    public partial class ShowInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlDataSource2.Insert();
            GridView2.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Panel1.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Panel1.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if(Button4.Text == "Редактировать заказы")
            {
                GridView2.AutoGenerateEditButton = true;
                Button4.Text = "Завершить редактирование";
            }
            else
            {
                GridView2.AutoGenerateEditButton = false;
                Button4.Text = "Редактировать заказы";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Button5.Text == "Удалить заказ")
            {
                GridView2.AutoGenerateDeleteButton = true;
                Button5.Text = "Завершить удаление";
            }
            else
            {
                GridView2.AutoGenerateDeleteButton = false;
                Button5.Text = "Удалить заказ";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SqlDataSource1.Insert();
            GridView1.DataBind();
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            Panel2.Visible = false;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Panel2.Visible = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (Button7.Text == "Редактировать закачика")
            {
                GridView1.AutoGenerateEditButton = true;
                Button7.Text = "Завершить редактирование";
            }
            else
            {
                GridView1.AutoGenerateEditButton = false;
                Button7.Text = "Редактировать закачика";
            }
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (Button8.Text == "Удалить заказчика")
            {
                GridView1.AutoGenerateDeleteButton = true;
                Button8.Text = "Завершить удаление";
            }
            else
            {
                GridView1.AutoGenerateDeleteButton = false;
                Button8.Text = "Удалить заказчика";
            }
        }
    }
}