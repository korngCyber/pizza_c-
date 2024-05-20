using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DatabaseConnection.windowsAuthentication();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try 
            {
                string sql = "SELECT Img FROM tbProducts";
                SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] data = (byte[])reader[0]; // Assuming "Img" is the column name for image data
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox1.Image = image;
                    }
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
