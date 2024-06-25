using System.ComponentModel.DataAnnotations;

namespace EditorPriceListExemple.Models
{
    public class Goods
    {
        [Key]
        public int GoodsID { get; set; }
        public string GoodsName { get; set; }
        public int GoodsCode { get; set; }
        public List<PriceList> PriceLists { get; set; } = new();
        public List<AttributeGoodsWithValue> Attributes { get; set; } = new();
    }
}
