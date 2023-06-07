using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411018816.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music(string name, string num)
        {
            var result = "";
            switch (num)
            {
                case "1":
                    result = "do";
                    break;
                case "2":
                    result = "re";
                    break;
                case "3":
                    result = "mi";
                    break;
                case "4":
                    result = "fa";
                    break;
                case "5":
                    result = "so";
                    break;
                case "6":
                    result = "la";
                    break;
                case "7":
                    result = "xi";
                    break;
                default:
                    result = "錯誤";
                    break;
            }
            ViewBag.name = name;
            ViewBag.Result = result;
            return View();
        }
    }
}