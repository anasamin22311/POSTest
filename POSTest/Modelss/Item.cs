using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POSTest.Modelss
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual List<Size> Sizes { get; set; }
        public string image { get; set; }
    }
}
