using EditorPriceListExemple.Interface;
using EditorPriceListExemple.Models;
using EditorPriceListExemple.VIewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EditorPriceListExemple.Controllers
{
    public class PriceListController :Controller
    {
        public readonly IPriceList _priceList;
        public readonly IAttribute _attribute;
        public PriceListController(IPriceList priceList, IAttribute attribute)
        {
            _priceList = priceList;
            _attribute= attribute;
        }

        public IActionResult IndexPriceList()
        {
           // _priceList.addDefaultValue();
            return View(_priceList.AllPriceList.OrderByDescending(x=>x.PriceListID));
        }

        public IActionResult CardPriceList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CardPriceList(PriceList priceList)
        {

            _priceList.AddAndEditPriceListAsync(priceList);
            return RedirectToAction("IndexPriceList", "PriceList");
        }

        public IActionResult AddPriceList ()
        {
            PriceList priceList = new PriceList() {PriceListName=$"Прайс-лист от {DateTime.Now.ToShortDateString()}" };
            ViewBag.TypeAttribute = new SelectList(_attribute.allTypeAttrebute, "TypeAttributeID", "TypeAttribute");
            return View("CardPriceList", priceList);
        }
        public IActionResult EditPriceList(int priceListID)
        {

            PriceList priceList = _priceList.GetPriceListByID(priceListID);
            ViewBag.TypeAttribute = new SelectList(_attribute.allTypeAttrebute, "TypeAttributeID", "TypeAttribute");
            return View("CardPriceList",priceList);
        }
    }
}
