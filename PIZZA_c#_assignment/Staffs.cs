using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZA_c__assignment
{
    internal class Staffs
    {
        public string staid { get; set; }
        public string staname { get; set; }
        public string stasex { get; set; }
        public string stapassword {  get; set; }
        public static List<Staffs> staffs=new List<Staffs>();
        public Staffs(string staid, string staname, string stasex, string stapassword)
        {
            this.staid = staid;
            this.staname = staname;
            this.stasex = stasex;
            this.stapassword = stapassword;
        }
        public static void SelectStaffs(string username,string password)
        {
            string sql = "SearchStaff";
            SqlCommand cmd=new SqlCommand(sql,DatabaseConnection.dataCon);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", username);
            cmd.Parameters.AddWithValue("@password",password);
            SqlDataReader r=cmd.ExecuteReader();
            while (r.Read()) 
            {
                string id = r[0].ToString();
                string name = r[1].ToString();
                string sex= r[2].ToString();
                string pwd= r[3].ToString();
                Staffs st=new Staffs(id, name, sex, pwd);
                staffs.Add(st);
            }
            r.Close();
            cmd.Dispose();
        }
    }
}
