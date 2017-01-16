using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult ChangeTheme(string themename)
        {
            Session["CssTheme"] = themename;
            if (Request.UrlReferrer !=null)
            {
                var returnUrl = Request.UrlReferrer.ToString();
                return new RedirectResult(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}