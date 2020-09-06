using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_11._2_Coffee_Shop_Registration.Models;

namespace Lab_11._2_Coffee_Shop_Registration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The HOTNESS of Cool Beans Coffee.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let us know how we're doing!";

            return View();
        }
        public ActionResult Registration()
        {
            ViewBag.Message = "Register Here.";

            return View();
        }
        public ActionResult Menu()
        {
            ViewBag.Message = "Order Here.";

            return View();
        }
        public ActionResult ShoppingCart()
        {
            ViewBag.Message = "View Your Order Here.";

            return View();
        }
        public ActionResult Save(string username, string firstname, string lastname, string emailaddress, string phonenumber, string birthday, string state, string password, string color)
        {
            WebUser user = new WebUser()
            {
                UserName = username,
                FirstName = firstname,
                LastName = lastname,
                Email = emailaddress,
                PhoneNumber = phonenumber,
                BDay = birthday,
                State = state,
                Password = password,
                FavoriteColor = color
            };
            return View(user);
        }
    }
}