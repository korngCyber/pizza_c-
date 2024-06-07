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
            string username = "korngkorng";
            string password = "1";
            DatabaseConnection.sqlAuthentication(username, password);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                //DatabaseConnection.windowsAuthentication();

                if (Product.Login(username, password))
                {
                    Staffs.SelectStaffs(username,password);
                    this.Dispose();
                    //new ContainerForm(this).ShowDialog();
                    new main4Form().ShowDialog();   
                }
                else
                  MessageBox.Show("Incorrect Username or Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
