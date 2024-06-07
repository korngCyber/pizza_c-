using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    public partial class ProductUS : UserControl
    {
        public int count=0;
        Product product;
        public ProductUS(Product product)
        {

            InitializeComponent();
            this.product = product;
            txtProName.Text=product.proName;
            decimal p = Convert.ToDecimal(product.price[0]);
            string price=p.ToString("C2");
            txtProPrice.Text = price;
            for (int i = 0;i<product.size.Count;i++) 
            {
                uiComboBox.Items.Add(product.size[i]);
            }
            picBox.Image=product.img;
            uiComboBox.SelectedIndex = 0;
            btnCancel.Visible=false;
        }
        public int qty { get; set; }
        private void uiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexcomBo=uiComboBox.SelectedIndex;
            decimal p= Convert.ToDecimal(product.price[indexcomBo]);
            if (count > 0)
            {
                string price = p.ToString("C2");
                txtProPrice.Text = price;
            }
            count++;
        }
        Order ord;
        private void btnAddcash_Click(object sender, EventArgs e)
        {

            
            int indexcomBo = uiComboBox.SelectedIndex;
            qty++;
            string qtyy=qty.ToString();
            btnAddcash.Text = $" Add cash({qtyy})";
            btnCancel.Visible = true;
            int index = int.Parse(checkID(product.proId));
            if (index >= 0)
            {
                decimal total = 0, oldPrice = 0;
                Order.orders[index].qty = qty.ToString();
                if (indexcomBo ==0)
                {
                    oldPrice = Convert.ToDecimal(product.price[indexcomBo]);
                    total=oldPrice + Convert.ToDecimal(Order.orders[index].priceOUT);
                    Order.orders[index].priceOUT =total.ToString();
                }
                else if(indexcomBo ==1)
                {
                    
                    oldPrice = Convert.ToDecimal(product.price[indexcomBo]);
                    total = oldPrice + Convert.ToDecimal(Order.orders[index].priceOUT);
                    Order.orders[index].priceOUT = total.ToString();
                }
                else
                {
                    oldPrice = Convert.ToDecimal(product.price[indexcomBo]);
                    total = oldPrice + Convert.ToDecimal(Order.orders[index].priceOUT);
                    Order.orders[index].priceOUT = total.ToString();
                }
                
            }
            else
            {
                Image img=picBox.Image;
                string pro_id = product.proId;
                string name = product.proName;
                string price =product.price[indexcomBo];
                ord = new Order(pro_id, name, qty.ToString(), price,img);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            qty=0;
            //int indexcomBo=uiComboBox.SelectedIndex;
            //string qtyy = qty.ToString();
            //btnAddcash.Text = $" Add cash({qtyy}) ";
            //if (qty <= 0)
            //{
                btnCancel.Visible = false;
                btnAddcash.Text = " Add cash";

            int index = int.Parse(checkID(product.proId));
            if (index >= 0)
            {
                Order.orders.RemoveAt(index);
            }
        }
        private string checkID(string id)
        {
            for(int i = 0; i < Order.orders.Count; i++) 
            {
                if (Order.orders[i].proID.Equals ((id)))
                    return i.ToString();
            }
            return "-1";
        }
    }
}
