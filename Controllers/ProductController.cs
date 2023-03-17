using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _10.Controllers;
using _10.Models;
using _10.Data_Access;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Reflection;

namespace _10.Controllers
{
    public class ProductController : Controller
    {
            private ProductRippo _ProductRippo = new ProductRippo();
        
            public IActionResult List()
            {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }

            var result = _ProductRippo.GetList();
            return View(result);
               
            }
        public IActionResult Search( string search)
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            var result = _ProductRippo.GetList();
            if (search != null)
            {
                ViewBag.Search = search;
                result = result.Where(x => x.Name.Contains(search)).ToList();
            }
            else
            {
                ViewBag.Search = "همه موارد";
            }
            return View(result);
        }

        public IActionResult Create()
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            //throw new DivideByZeroException();
            return View();
        }
        public IActionResult Delete(int id)
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            var result = _ProductRippo.GetList();
            foreach (var p in result)
            {
                if (p.Id == id)
                {
                    _ProductRippo.Delete(p.Id);
                    return RedirectToAction("AdminActions","Admin");
                }

            }
            return View("Home/Error");
        }

        public IActionResult Action()
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            return View();
        }
     
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            var currentItem = _ProductRippo.GetList().Last();
            var result = _ProductRippo.GetList();

             foreach(var n in  result)
            {
                if(n.Name == model.Name)
                {
                    n.Number = n.Number + model.Number;
                    return RedirectToAction("List");
                }
               
            }
                _ProductRippo.Add(new Product
                {
                    Id = currentItem.Id + 1,
                    Name = model.Name,
                    Number = model.Number,
                    Price = model.Price,
                });
            
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            var entity = _ProductRippo.Get(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(int id, string name, int number, decimal price)

        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            var result = _ProductRippo.GetList();
            foreach (var n in result)
            {

                if(n.Id == id)
                {
                _ProductRippo.Edite(id, name, number, price);
                return RedirectToAction("List");
                }
            }
            return View("Home/Error");
        }

    }
}
