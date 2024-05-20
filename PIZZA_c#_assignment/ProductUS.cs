using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            txtProPrice.Text = product.price[0];
            for (int i = 0;i<product.size.Count;i++) 
            {
                uiComboBox.Items.Add(product.size[i]);
            }
            picBox.Image=product.img;
            uiComboBox.SelectedIndex = 0;
        }

        private void uiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=uiComboBox.SelectedIndex;
            if (count > 0)
                txtProPrice.Text = product.price[index];
            count++;
        }
    }
}
