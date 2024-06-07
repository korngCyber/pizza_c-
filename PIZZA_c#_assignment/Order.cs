using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZA_c__assignment
{
    public class Order
    {
        public string proID {  get; set; }
        public string proName { get; set; }
        public string qty { get; set; }
        public string priceOUT { get; set; }
        public Image img { get; set; }
        public static List<Order> orders= new List<Order>();
        public Order(string proID, string proName, string qty, string priceOUT,Image img)
        {
            //string compareID = "0";
            int lastindex = orders.Count;
            this.proID = proID;
            this.proName = proName;
            this.priceOUT = priceOUT;
            this.qty = qty;
            this.img = img;
            orders.Add(this);
        }
        //private bool isIDAvailable()
        //{
        //    string id=proID;
        //    foreach(Order ord in orders)
        //    {
        //        if(ord.proID==id)
        //            return true;
        //    }
        //    return false;
        //}

        public Order() { }

    }
}
