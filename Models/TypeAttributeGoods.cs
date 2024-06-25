using System.ComponentModel.DataAnnotations;

namespace EditorPriceListExemple.Models
{
    public class TypeAttributeGoods
    {
        [Key]
        public int TypeAttributeID { get; set; }
        public string TypeAttribute { get; set; }
        public List<AttributeGoods> AttributesGoods { get; set; } = new();
    }
}
