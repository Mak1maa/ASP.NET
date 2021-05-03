using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace PracticeWork5
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int AddMultiplication(int a, int b)
        {
            return a * b;
        }

        [WebMethod]
        public int AddDivision(int a, int b)
        {
            return a / b;
        }

        [WebMethod]
        public int AddSubtraction(int a, int b)
        {
            return a - b;
        }

        [WebMethod]
        public DataSet GetCustomers()
        {
            SqlConnection conn;
            SqlDataAdapter myDataAdapter;
            DataSet myDataSet;
            string cmdString = "SELECT * FROM Customers";
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            conn = new SqlConnection(cs);
            myDataAdapter = new SqlDataAdapter(cmdString, conn);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "Customers");
            return myDataSet;
        }
    }
}