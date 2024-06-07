using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    internal class ProductInfo
    {
        public static byte[] ImageToByteArray(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public static void searchProduct(Guna.UI2.WinForms.Guna2TextBox name, DataGridView dataGrid)
        {
            try
            {
                dataGrid.Rows.Clear();
                string sql = "SearchProduct";
                SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name.Text);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string id = r[0].ToString();
                    string nammee = r[1].ToString();
                    string flav = r[2].ToString();
                    string category = r[3].ToString();
                    byte[] data = (byte[])r[4];
                    Image imge;
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        imge = Image.FromStream(ms);
                    }
                    dataGrid.Rows.Add(id, nammee, flav, category, imge);
                }
                r.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void refresh(DataGridView dataGrid)
        {
            try
            {
                dataGrid.Rows.Clear();
                string sql = "Refresh";
                SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string id = r[0].ToString();
                    string nammee = r[1].ToString();
                    string flav = r[2].ToString();
                    string category = r[3].ToString();
                    byte[] data = (byte[])r[4];
                    Image imge;
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        imge = Image.FromStream(ms);
                    }
                    dataGrid.Rows.Add(id, nammee, flav, category, imge);
                }
                r.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void update(string id, string name, string flavour, string category, Image image)
        {
            try
            {
                string cateID;
                if (category.Equals("Pizza"))
                    cateID = "1";
                else if (category.Equals("Drink"))
                    cateID = "2";
                else
                    cateID = "3";
                byte[] imageByte = ImageToByteArray(image);
                if (name != "" && flavour != "" && id != "")
                {
                    string sql = "UpdateProduct";
                    SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@flav", flavour);
                    cmd.Parameters.AddWithValue("@cat", cateID);
                    cmd.Parameters.AddWithValue("@pic", imageByte);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Not allow null value", "Update not success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void delete(string id)
        {
            DialogResult dr;
            dr = MessageBox.Show($"Do you want to delete ProductID={id} ?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (id != "")
                {
                    string sql = "DeleteProductPrice";
                    SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    sql = "DeleteProduct";
                    cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successful");
                    cmd.Dispose();
                }
                else
                    MessageBox.Show("Not allow null value", "delete not success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void insert(string id, string name, string flavour, string category, Image image)
        {
            try
            {
                string cateID;
                if (category.Equals("Pizza"))
                    cateID = "1";
                else if (category.Equals("Drink"))
                    cateID = "2";
                else
                    cateID = "3";
                byte[] imageByte = ImageToByteArray(image);
                if (name != "" && flavour != "" && id != "")
                {
                    string sql = "InsertProduct";
                    SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@flav", flavour);
                    cmd.Parameters.AddWithValue("@cat", cateID);
                    cmd.Parameters.AddWithValue("@pic", imageByte);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    sql = "InsertProductPrice";
                    cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Not allow null value", "Insert not success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
