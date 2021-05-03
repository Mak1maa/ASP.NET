using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeWork7.Models;
using System.Data.SqlClient;
using System.Data;

namespace PracticeWork7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро!" : "Доброго дня!";

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse gr)
        {
            if (ModelState.IsValid)
            {
                string str = System.Configuration.ConfigurationManager.ConnectionStrings["PeopleDB"].ConnectionString;
                string commandText = "INSERT INTO InformationAboutPeople (Name, Email, Phone, WillAttend) VALUES (@Name, @Email, @Phone, @WillAttend)";
                using (SqlConnection con = new SqlConnection(str))
                {
                    SqlCommand command = new SqlCommand(commandText, con);
                    command.Parameters.Add("@Name", SqlDbType.NVarChar);
                    command.Parameters["@Name"].Value = gr.Name;

                    command.Parameters.Add("@Email", SqlDbType.NVarChar);
                    command.Parameters["@Email"].Value = gr.Email;

                    command.Parameters.Add("@Phone", SqlDbType.NVarChar);
                    command.Parameters["@Phone"].Value = gr.Phone;

                    command.Parameters.Add("@WillAttend", SqlDbType.Bit);
                    command.Parameters["@WillAttend"].Value = gr.WillAttend;
                    try
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        View("Error...", ex);
                    }
                }
                return View("Thanks", gr);
            }
            else
            {
                return View();
            }
        }

        public ViewResult InfoPeople()
        {
            List<GuestResponse> list = new List<GuestResponse>();
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["PeopleDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM InformationAboutPeople", con);
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    GuestResponse gs = new GuestResponse();
                    gs.Name = r["Name"].ToString();
                    gs.Email = r["Email"].ToString();
                    gs.Phone = r["Phone"].ToString();
                    gs.WillAttend = (bool)r["WillAttend"];
                    list.Add(gs);
                }
            }
            ViewBag.Item = list;
            return View();
        }
    }
}