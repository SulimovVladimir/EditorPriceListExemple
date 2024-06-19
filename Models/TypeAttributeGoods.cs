namespace EditorPriceListExemple.Models
{
    public class TypeAttributeGoods
    {
        public int TypeAttributeID { get; set; }
        public string TypeAttribute { get; set; }
        public List<AttributeGoods> AttributesGoods { get; set; } = new();
    }
}
