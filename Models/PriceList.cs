using System.ComponentModel.DataAnnotations;

namespace EditorPriceListExemple.Models
{
    public class PriceList
    {
        [Key]
        public int PriceListID { get; set; }
        public string PriceListName { get; set; }
        public List<Goods> GoodsList { get; set; } = new ();
        public List<AttributeGoods> AttributesGoods { get; set; } = new();
    }
}