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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (!checkpassword.Checked)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            { txtPassword.PasswordChar = '\0'; }
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            ContainerForm ctn = new ContainerForm();
            ctn.Show(); 
            this.Hide();
        }
    }
}
