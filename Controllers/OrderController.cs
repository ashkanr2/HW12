using _10.Data_Access;
using _10.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace _10.Controllers
{
    public class OrderController : Controller
    {
        private ProductRippo _ProductRippo = new ProductRippo();
        private OrderRippo _OrderRippo = new OrderRippo();

        public IActionResult List()
        {
            if (AcountRippo.currentuser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (AcountRippo.currentuser.user == Models.user.admin)
            {
                ViewBag.Log = "خروج";
                ViewBag.ErAdmin = "ادمین نمیتواند سفارش دهد ";
                return RedirectToAction("ErroAdmin", "Admin");
            }

            ViewBag.Log = "خروج";
            ViewBag.Name = AcountRippo.currentuser.Name;
            decimal? TotalPrice = 0;
            var result = _OrderRippo.GetList();
            ViewBag.Id = AcountRippo.currentuser.Id;
            foreach (var item in result)
            {
            }
            ViewBag.Products= _ProductRippo.GetList();
            return View(result);

        }
        public IActionResult OrderList(int id)
        {
            ViewBag.OrderId=id;
            var result = _OrderRippo.GetList();
            return View(result);
        }

        public IActionResult Delete(int Id)

        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            foreach (var item in _ProductRippo.GetList())
            {
                if (item.Id == Id)
                {

                    item.Number = item.Number + item.Number2;
                    item.Number2 = 0;
                    item.PersonId = null;
                    break;
                }
            }

            return RedirectToAction("List");

        }

        public IActionResult Delete2(int Id)

        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            foreach (var item in _ProductRippo.GetList())
            {
                if (item.Id == Id)
                {

                    item.Number++;
                    item.Number2--;
                    break;
                }
            }

            return RedirectToAction("List");

        }
        public IActionResult AddNewOrder(int Id)
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            var currentItem = _OrderRippo.GetList().Last();
            var result = _OrderRippo.GetList();
            var resultProduct = _OrderRippo.GetList();

            _OrderRippo.Add(new Order
            {
                Id = currentItem.Id + 1,
                CustomerId = AcountRippo.currentuser.Id,
                Productid= new List<int> {Id}
            });

            return RedirectToAction("List");



        }
        public IActionResult AddToOrder(int orderId, int productId)
        {
            
            return RedirectToAction("List");

        }
    }
}
