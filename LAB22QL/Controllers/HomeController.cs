using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAB22QL.Models;

namespace LAB22QL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            CoffeetypesEntities CoffeeDB = new CoffeetypesEntities();
            List<Coffeelist> AllCoffee = CoffeeDB.Coffeelists.ToList();
            ViewBag.EmpList = AllCoffee;

            return View();


            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UserRegistration()
        {
            return View();
        }

        public ActionResult SavedUserInfo(UserRegistration NewUser)
        {
            UserInfoEntities UserInfoDB = new UserInfoEntities(); //este metodo es para mostrar en el view que se llama new employye para que display los datos del new employee
            UserInfoDB.UserRegistrations.Add(NewUser);// saves the new employee to the list 

            UserInfoDB.SaveChanges(); //saves the new employee to the db

            return RedirectToAction("Thankyouview");
        }

        public ActionResult Thankyouview()
        {

            return View();
        }
    }
}