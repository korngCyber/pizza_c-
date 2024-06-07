
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        private main4Form THIS;
        public ContainerForm(main4Form THIS)
        {
            InitializeComponent();
            this.THIS = THIS;
        }
        private void ContainerForm_Load(object sender, EventArgs e)
        {
            Product.InitializeProduct();
            btnPizza.PerformClick();
        }
        private Order ord;
        private void btnPizza_Click(object sender, EventArgs e)
        {
            while (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.Controls[0].Dispose();
            }

            int column = 1, row = 0;
            for (int i = 0; i < Product.products.Count; i++)
            {
                if (Product.products[i].catID.Equals("1"))
                {
                    ProductUS p = new ProductUS(Product.products[i]);
                    tableLayoutPanel1.Controls.Add(p, column, row);
                    column++;
                    if (column > 3)
                    {
                        row++;
                        column = 1;
                    }
                }
            }
           
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            while (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.Controls[0].Dispose();
            }

            int column = 1, row = 0;
            for (int i = 0; i < Product.products.Count; i++)
            {
                if (Product.products[i].catID.Equals("3"))
                {
                    ProductUS p = new ProductUS(Product.products[i]);
                    tableLayoutPanel1.Controls.Add(p, column, row);
                    column++;
                    if (column > 3)
                    {
                        row++;
                        column = 1;
                    }
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            THIS.Show();
             
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            while (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.Controls[0].Dispose();
            }

            int column = 1, row = 0;
            for (int i = 0; i < Product.products.Count; i++)
            {
                if (Product.products[i].catID.Equals("2"))
                {
                    ProductUS p = new ProductUS(Product.products[i]);
                    tableLayoutPanel1.Controls.Add(p, column, row);
                    column++;
                    if (column > 3)
                    {
                        row++;
                        column = 1;
                    }
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentForm pf = new PaymentForm(this);
            if(pf.ShowDialog()==DialogResult.OK) 
            {
                while (tableLayoutPanel1.Controls.Count > 0)
                {
                    tableLayoutPanel1.Controls[0].Dispose();
                }
                
                btnPizza.PerformClick();
            }

            //this.Hide();
            //new PaymentForm(this).Show();   
        }
    }
}
