using BusinessLogic;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealerManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserBusinessObject objUserBusinessObject)
        {
            if (ModelState.IsValid)
            {
                UserBL objUserBL = new UserBL();
                UserCustomBO objserCustomBO = objUserBL.AddUser(objUserBusinessObject);
                return RedirectToAction("Index");
            }
            return View(objUserBusinessObject);
        }
    }
}