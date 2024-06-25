using EditorPriceListExemple.Interface;
using EditorPriceListExemple.Models;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using System.Linq;

namespace EditorPriceListExemple.Repository
{
    public class AttrebuteRepository : IAttribute
    {
        private readonly AppDBContext _appDB;
        private readonly IPriceList _priceList;

        public AttrebuteRepository(AppDBContext appDB, IPriceList priceList)
        {
            _appDB = appDB;
            _priceList = priceList;
        }
        public IEnumerable<AttributeGoods> allAttribute => _appDB.AttributesGoods;

        public IEnumerable<TypeAttributeGoods> allTypeAttrebute => _appDB.TypesAttributeGoods;

     
    }
}
