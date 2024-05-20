using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    internal class DatabaseConnection
    {
        public static SqlConnection dataCon { get; set; }
        public static string user { get; set; }
        public static void sqlAuthentication(string username, string password)
        {
            string connectStr = $"Server=.;Database=Pizza;User Id={username};Password={password};";
            dataCon = new SqlConnection(connectStr);
            dataCon.Open();
            user = username;
        }
        public static void windowsAuthentication()
        {
            string connectionStr = "Server=.;Database=Pizza;Trusted_Connection=True;";
            dataCon = new SqlConnection(connectionStr);
            dataCon.Open();
            user=Environment.UserName;
        }
    }
}
