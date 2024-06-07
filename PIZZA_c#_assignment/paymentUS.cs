using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    public partial class paymentUS : UserControl
    {
        Order ord;
        public paymentUS(Order ord)
        {
            InitializeComponent();
            
            this.ord = ord;
            decimal price = Convert.ToDecimal(ord.priceOUT);
            txtName.Text = ord.proName;
            txtQty.Text=ord.qty;
            txtAmount.Text = price.ToString("C2");
            picBox.Image=ord.img;
        }
        
    }
}
