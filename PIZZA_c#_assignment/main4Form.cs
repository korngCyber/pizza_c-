using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    public partial class main4Form : Form
    {

        public main4Form()
        {
            InitializeComponent();
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
        
            this.Hide();
            new ContainerForm(this).ShowDialog();
        }

       

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new ProductForm().ShowDialog();
        }

    }
}
