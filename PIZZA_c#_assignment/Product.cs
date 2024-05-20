using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    public class Product
    {
        public string proId { get; set; }
        public string proName {  get; set; }
        public string catID {  get; set; }
        public List< string> size =new List< string>();
        public List<string> price =new List< string>();
        public Image img { get; set; }
        public static List<Product> products=new List<Product>();
       
        Product(string proId, string proName, string size, string price,Image img,string catID)
        {
            this.proId = proId;
            this.proName = proName;
            this.img = img;
            this.catID= catID;
            this.size.Add(size);
            this.price.Add(price);
        }
        Product() { }
        public static void InitializeProduct()
        {
           
            try 
            {
                //SELECT StaName,StaPwd from tbStaffs WHERE StaName ='Seth' AND PWDCOMPARE(N'Password',StaPwd)=1
                string idCompare = "0";
                string sql = "SelectProduct";
                SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string pid = reader[0].ToString();
                    string pname = reader[1].ToString();
                    string psize = reader[2].ToString();
                    string price= reader[3].ToString();
                    byte[] data = (byte[])reader[4];
                    Image imge;
                    using (MemoryStream ms = new MemoryStream(data)) 
                    {
                       imge =Image.FromStream(ms);
                    }
                    string catid = reader[5].ToString();
                    
                   if(!pid.Equals(idCompare))
                   {
                        idCompare= pid;
                        Product product= new Product(pid,pname,psize,price,imge,catid);
                        products.Add(product);
                   }
                   else 
                   {
                        int lastIndex=products.Count-1;
                        products[lastIndex].size.Add(psize);
                        products[lastIndex].price.Add(price);

                   }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool Login(String txtUsername, String txtPassword)
        {

            try
            {
                //SELECT StaName,StaPwd from tbStaffs WHERE StaName ='Seth' AND PWDCOMPARE(N'Password',StaPwd)=1
                string idCompare = "0";
                string sql = $"SELECT StaName from tbStaffs WHERE StaName ='{txtUsername}' AND PWDCOMPARE(N'{txtPassword}',StaPwd)=1";
                SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.Close();
                    return true;
                }
                reader.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
    
}
