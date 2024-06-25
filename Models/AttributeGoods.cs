using System.ComponentModel.DataAnnotations;

namespace EditorPriceListExemple.Models
{
    public class AttributeGoods
    {
        [Key]
        public int AttributeGoodsID { get; set; }
        public string NameAttributeGoods { get; set; }
        public List<AttributeGoodsWithValue> JornalAttribute = new();
        public List<PriceList> PriceLists = new();
        public int TypeAttributeID { get; set; }
        public TypeAttributeGoods TypeAttributeGoods { get; set; }

    }
}
