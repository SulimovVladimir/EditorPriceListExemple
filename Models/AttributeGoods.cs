namespace EditorPriceListExemple.Models
{
    public class AttributeGoods
    {
        public int AttributeGoodsID { get; set; }
        public string NameAttributeGoods { get; set; }
        public List<AttributeGoodsWithValue> JornalAttribute = new();
        public int TypeAttributeID { get; set; }
        public TypeAttributeGoods TypeAttributeGoods { get; set; }

    }
}
