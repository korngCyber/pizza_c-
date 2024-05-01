
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
            decimal p = 0;
            try
            {
                string sql = "SELECT ProName,PriceOUT FROM tbProducts";
                SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                SqlDataReader r = cmd.ExecuteReader();
                int column = 0, row = 0, id = 1;
                while (r.Read())
                {
                    ProductUS pro = new ProductUS();
                    pro.Product_Name = r[0].ToString();
                    int index = pro.combo.SelectedIndex;
                    decimal price = r.GetDecimal(1);
                   if (index == 0)
                    {
                        p = price;
                    }
                   else if (index == 1) 
                   {
                        p = price + 2;
                   }
                   else 
                   {
                        p = price+4;
                   }
                    pro.Product_price = p.ToString("C", System.Globalization.CultureInfo.CurrentCulture);
                    // l == price(default) 
                    // M ==  price + 2.00
                    // S == price + 300
                    tableLayoutPanel1.Controls.Add(pro,column,row);
                    column++;
                    if (column > 2)
                    {
                        row++;
                        column = 0;
                    }
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
