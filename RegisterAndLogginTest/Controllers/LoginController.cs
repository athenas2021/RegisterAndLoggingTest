using RegisterAndLogginTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegisterAndLogginTest.Controllers
{
    public class LoginController : Controller
    {
        // GET: Loggin
        public ActionResult Index()
        {

            return View();
        }
                
        public ActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "BillGates" && userModel.Password == "bigbucks")
            {
                return View("LoginSuccess", userModel);
            } else
            {
                return View("LoginFailure", userModel);        
            }
        }
    }
}