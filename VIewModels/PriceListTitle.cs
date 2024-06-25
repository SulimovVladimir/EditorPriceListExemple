using EditorPriceListExemple.Models;

namespace EditorPriceListExemple.VIewModels
{
    public class PriceListTitle
    {
        public PriceList PriceList { get; set; }
        public List<AttributeGoods> attributeGoods { get; set; }
    }
}
