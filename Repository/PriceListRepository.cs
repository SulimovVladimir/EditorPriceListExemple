using EditorPriceListExemple.Interface;
using EditorPriceListExemple.Models;
using Microsoft.EntityFrameworkCore;

namespace EditorPriceListExemple.Repository
{
    public class PriceListRepository :IPriceList
    {
        private readonly AppDBContext _appDB;

        public PriceListRepository(AppDBContext appDB)
        {
            _appDB = appDB;
        }

        public IEnumerable<PriceList> AllPriceList => _appDB.PriceLists;


        public PriceList GetPriceListByID(int PriceListID) => _appDB.PriceLists.Include(s=>s.AttributesGoods).First(x => x.PriceListID == PriceListID);
        
        public void addDefaultValue()
        {
            TypeAttributeGoods type = _appDB.TypesAttributeGoods.First();
            AttributeGoods attribute1= new AttributeGoods() {TypeAttributeGoods=type, NameAttributeGoods="param1"};
            _appDB.AttributesGoods.Add(attribute1);
            PriceList priceList=_appDB.PriceLists.First();
            priceList.AttributesGoods.Add(attribute1);
            _appDB.SaveChanges();
        }

        public void AddAndEditPriceListAsync(PriceList priceList)
        {
            List<TypeAttributeGoods> tempType = _appDB.TypesAttributeGoods.ToList();
            List<AttributeGoods> tempListAttribute = priceList.AttributesGoods;
            List<AttributeGoods> removeListAttribute = new();
            foreach (AttributeGoods attribute in tempListAttribute) 
            {
                if (attribute.NameAttributeGoods == null)
                {
                    removeListAttribute.Add(attribute);
                    continue;
                    
                }
                    TypeAttributeGoods type = tempType.First(x => x.TypeAttributeID == attribute.TypeAttributeID);
                    type.AttributesGoods.Add(attribute);
            }
            foreach (AttributeGoods removeAttribute in removeListAttribute)
            {
                _appDB.AttributesGoods.Remove(removeAttribute);
                tempListAttribute.Remove(removeAttribute);
            }
            _appDB.AttributesGoods.UpdateRange(tempListAttribute);
            _appDB.PriceLists.Update(priceList);
           _appDB.SaveChanges();
        }
    }
}
