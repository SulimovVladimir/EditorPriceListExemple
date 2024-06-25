using EditorPriceListExemple.Interface;
using EditorPriceListExemple.Models;

namespace EditorPriceListExemple.Repository
{
    public class GoodsRepository :IGoods
    {
        private readonly AppDBContext _appDB;

        public GoodsRepository(AppDBContext appDB)
        {
            _appDB = appDB;
        }
    }
}
