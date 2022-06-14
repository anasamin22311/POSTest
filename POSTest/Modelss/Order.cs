using System;
using System.Collections.Generic;

namespace POSTest.Modelss
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }= DateTime.Now;
        public List <Item> Items{ get; set; }

    }
}
