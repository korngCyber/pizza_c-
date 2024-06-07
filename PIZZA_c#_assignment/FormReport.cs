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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        public void setParameter(int index,Object value)
        {
            CrystalReport11.SetParameterValue(index,value);
        }
        public void setSource()
        {
            CrystalReport11.SetDataSource(Order.orders);
        }
        public void print(int copy,bool coll,int start,int end)
        {
            CrystalReport11.PrintToPrinter(copy,coll,start,end);
        }
    }
}
