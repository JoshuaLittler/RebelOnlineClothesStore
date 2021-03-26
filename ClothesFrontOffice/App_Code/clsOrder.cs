using System;

namespace Clothes_Testing
{
    public class clsOrder
    {
        public string Order_Type { get; set; }
        public string Order_ID { get; set; }
        public string Order_Cus_No { get; set; }
        public string Order_Product_ID { get; set; }
        public object Order_Date { get; set; }

        public bool Find(int order_ID)
        {
            throw new NotImplementedException();
        }
    }
}