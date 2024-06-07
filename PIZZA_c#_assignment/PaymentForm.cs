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
    public partial class PaymentForm : Form
    {
        private ContainerForm THIS;
        public PaymentForm(ContainerForm THIS)
        {
            InitializeComponent();
            total = totalAmount();
            comboDis.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
            btnEnter.Enabled = false;
            txtAmount.Enabled = false;
            txtDisPrice.Enabled = false;
            txtReturn.Enabled = false;
            this.THIS = THIS;
        }
        public bool deliver { get; set; }
        public decimal total { get; set; }
        public decimal discount { get; set; }
        public decimal discountPrice { get; set; }
        public decimal pay { get; set; }
        public decimal recieved { get; set; }
        public decimal returnPrice { get; set; }
        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            THIS.Show();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            comboDis.SelectedIndex = 0;
            while (tableLayoutPanel.Controls.Count > 0)
            {
                tableLayoutPanel.Controls[0].Dispose();
            }
            int column = 1, row = 1;
            for (int i = 0;i<Order.orders.Count;i++) 
            {
                paymentUS pus=new paymentUS(Order.orders[i]);
                tableLayoutPanel.Controls.Add(pus,row,column);
                column++;
                if(column > 1) 
                {
                    row++;
                    column = 1;
                }
            }
            string luy = totalAmount().ToString("C2");
            txtAmount.Text = luy;

        }

        private decimal totalAmount()
        {
            decimal t = 0;
            for (int i = 0; i<Order.orders.Count;i++)
            {
                string ordPrice = Order.orders[i].priceOUT;
                decimal luy1 = decimal.Parse(ordPrice);
                t+= luy1;   
            }
            return t;
        }

        private void comboDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dis=comboDis.SelectedItem.ToString();
            dis = dis.Substring(0, dis.Length - 1);
            discount=decimal.Parse(dis)/100;
            discountPrice = total * discount;
            pay=total-discountPrice;
            txtDisPrice.Text=pay.ToString("C2");
        }

        private void txtRecieved_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                try 
                {
                    string cashRecieved=txtRecieved.Text.Trim();
                    recieved=decimal.Parse(cashRecieved);
                    returnPrice= recieved-pay;
                    txtReturn.Text = returnPrice.ToString("$#,##0.00");
                    if(recieved>=pay)
                        btnEnter.Enabled = true;
                    else
                        btnEnter.Enabled = false;
                }
                catch 
                {
                    txtReturn.Text = "$0.00";
                    btnEnter.Enabled = false;
                }
            }
            else 
            {
                btnEnter_Click(e,null);
            }
        }
        int cus = 0;
        private string InsertOrder()
        {
            cus++;
            bool type;
            int index=comboType.SelectedIndex;
            if (index == 0)
                type = true;
            else
                type = false;
            string date = DateTime.Now.ToString("yyy-MM-dd");
            string time=DateTime.Now.ToString("HH:mm:ss");
            string discount_price=discountPrice.ToString();
            string seller = Staffs.staffs[0].staname;
            string seller_id = Staffs.staffs[0].staid;
            
            string sql = "InsertCus";
            SqlCommand cmd=new SqlCommand(sql,DatabaseConnection.dataCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cusName", cus.ToString());
            cmd.Parameters.Add("@id",SqlDbType.Int).Direction= ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            string cusid = cmd.Parameters["@id"].Value.ToString();
            cmd.Dispose();


            if (string.IsNullOrEmpty(cusid))
            {
                throw new Exception("Customer ID could not be retrieved.");
            }
            sql = "InsertOrder";
            cmd=new SqlCommand(sql,DatabaseConnection.dataCon);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@dis", discount_price);
            cmd.Parameters.AddWithValue("@cusid",cusid);
            cmd.Parameters.AddWithValue("@staffID",seller_id);
            cmd.Parameters.AddWithValue("@name", seller);
            cmd.Parameters.Add("@id",SqlDbType.Int).Direction=ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string ordID = cmd.Parameters["@id"].Value.ToString();
            return ordID;
        }
        private void orderDetail(string ordID)
        {
            try 
            {
                foreach (Order i in Order.orders)
                {
                    string pid = i.proID + "";
                    string name = i.proName + "";
                    string odid = ordID;
                    string quantity = i.qty + "";
                    string price = i.priceOUT + "";
                    string sql = "InsertOrdd";
                    SqlCommand cmd = new SqlCommand(sql, DatabaseConnection.dataCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pid", pid);
                    cmd.Parameters.AddWithValue("@pname", name);
                    cmd.Parameters.AddWithValue("@oid", ordID);
                    cmd.Parameters.AddWithValue("@qty", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void printReport(string ordID)
        {
            FormReport rp= new FormReport(); //go to create function setSource and function set parameter in form report
            rp.setSource();
            rp.setParameter(0, ordID);
            rp.setParameter(1, Staffs.staffs[0].staname);
            discount = discount * 100;
            string disc=discount.ToString();
            disc +='%';
            rp.setParameter(2,disc);
            rp.setParameter(3,pay.ToString("C2"));
            rp.setParameter(4,recieved.ToString("C2"));
            rp.setParameter(5,returnPrice.ToString("C2"));
            string ordType = "";
            int index = comboType.SelectedIndex;
            if(index==0)
                ordType= comboType.SelectedItem.ToString();
            else
                ordType = comboType.SelectedItem.ToString();
            rp.setParameter(6,ordType);
            rp.print(1, true, 1, -1);
            rp.ShowDialog(); 
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            DialogResult dr;
            dr = MessageBox.Show("Please make sure you've already checked your order ", "Purchase?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try 
            {
                if (dr == DialogResult.Yes)
                {
                    //insertOrder
                    string ordID = InsertOrder();
                    //insertOrderDetail
                    orderDetail(ordID);
                    //print Report
                    printReport(ordID);
                    clear();
                    DialogResult=DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void clear() 
        {
            Order.orders.Clear();
            while (tableLayoutPanel.Controls.Count > 0)
            {
                tableLayoutPanel.Controls[0].Dispose();
            }
            txtAmount.Clear();
            txtDisPrice.Clear();
            comboDis.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
            MessageBox.Show("Successful Purchase");
        }
    }
}
