using System;

namespace Clothes_Testing
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public int OrderID { get; internal set; }
        public DateTime Date { get; internal set; }
        public int CusOrderID { get; internal set; }
        public int ProductOrderID { get; internal set; }
    }
}