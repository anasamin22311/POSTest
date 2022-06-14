using System.ComponentModel.DataAnnotations.Schema;

namespace POSTest.Modelss
{
    public class Size
    {
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public decimal SizePrice { get; set; }
        [ForeignKey("ItemId")]
        public int ItemId { get; set; }
        public Item item { get; set; }

    }
}
