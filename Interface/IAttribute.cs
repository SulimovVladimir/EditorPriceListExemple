using EditorPriceListExemple.Models;

namespace EditorPriceListExemple.Interface
{
    public interface IAttribute
    {
        IEnumerable<TypeAttributeGoods> allTypeAttrebute { get; }
        IEnumerable<AttributeGoods> allAttribute { get; }


    }
}
