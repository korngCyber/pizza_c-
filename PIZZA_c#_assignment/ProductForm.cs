using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_c__assignment
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            ProductInfo.refresh(dataGrid);
            txtProId.Enabled= false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new main4Form().ShowDialog();
        }
        private void clear()
        {
            txtProFlavor.Clear();
            txtProName.Clear();
            txtProId.Clear();
            txtProName.Clear();
            comboCat.SelectedIndex = 0;
            pictureBox.Image = Properties.Resources.No_Image_Available;
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGrid.SelectedRows.Count > 0) 
            {
                int index = dataGrid.SelectedRows[0].Index;
                txtProId.Text= dataGrid.Rows[index].Cells[0].Value.ToString();
                txtProName.Text = dataGrid.Rows[index].Cells[1].Value.ToString();
                txtProFlavor.Text = dataGrid.Rows[index].Cells[2].Value.ToString();
                string comb = dataGrid.Rows[index].Cells[3].Value.ToString();
                if (comb.Equals("Pizza"))
                    comboCat.SelectedIndex = 0;
                else if (comb.Equals("Drink")) 
                    comboCat.SelectedIndex = 1;
                else
                    comboCat.SelectedIndex = 2;

            }
        }

        private void btnProbrowe_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "ImageFile(*.jpg,*.bmp,*.png)|*.jpg;*.bmp;*.png;";
            DialogResult result = of.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image im = Image.FromFile(of.FileName);
                pictureBox.Image = im;
                MessageBox.Show(of.FileName);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "ImageFile(*.jpg,*.bmp,*.png)|*.jpg;*.bmp;*.png;";
            DialogResult result = of.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image im = Image.FromFile(of.FileName);
                pictureBox.Image = im;
                MessageBox.Show(of.FileName);

            }
        }

        private void btnProupdate_Click(object sender, EventArgs e)
        {
            string combo=comboCat.SelectedItem.ToString();
            string id=txtProId.Text.Trim();
            string name=txtProName.Text.Trim();
            string flav=txtProFlavor.Text.Trim();
            Image im=pictureBox.Image;
            ProductInfo.update(id, name, flav, combo, im);
            clear();
            ProductInfo.refresh(dataGrid);
        }

        private void txtProName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                ProductInfo.searchProduct(txtProName, dataGrid);
            }
            catch
            {
                ProductInfo.refresh(dataGrid);
            }
        }

        private void btnProDelte_Click(object sender, EventArgs e)
        {
            string id=txtProId.Text;
            ProductInfo.delete(id);
            clear();
            ProductInfo.refresh(dataGrid);
        }

        private void btnProsave_Click(object sender, EventArgs e)
        {

            string combo = comboCat.SelectedItem.ToString();
            string id = txtProId.Text.Trim();
            string name = txtProName.Text.Trim();
            string flav = txtProFlavor.Text.Trim();
            Image im = pictureBox.Image;
            ProductInfo.insert(id, name, flav, combo, im);
            clear();
            ProductInfo.refresh(dataGrid);
            txtProId.Enabled = false;
        }
        int count = 1;
        private void btnEnable_Click(object sender, EventArgs e)
        {
            if(count%2!=0)
            {
                txtProId.Enabled = true;
                btnEnable.Text = "Disable ID";
            }
            if( count % 2==0)
            {
                txtProId.Enabled = false;
                btnEnable.Text = "Click here to enable ID";
            }
                
            count++;
        }
    }
}
