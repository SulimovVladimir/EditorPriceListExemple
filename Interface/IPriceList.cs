using EditorPriceListExemple.Models;

namespace EditorPriceListExemple.Interface
{
    public interface IPriceList
    {
        IEnumerable<PriceList> AllPriceList { get; }
        PriceList GetPriceListByID(int PriceListID);
        void addDefaultValue();
        void AddAndEditPriceListAsync(PriceList priceList);
    }
}
