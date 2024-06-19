namespace EditorPriceListExemple.Models
{
    public class PriceList
    {
        public int PriceListID { get; set; }
        public string PriceListName { get; set; }
        public List<Goods> GoodsList { get; set; } = new ();
    }
}