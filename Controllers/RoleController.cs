using freshproject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace freshproject1.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext Context; 
        // GET: Role
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {


                if (!isAdminUser())
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            var Roles = Context.Roles.ToList();
            return View(Roles);

        }

        private bool isAdminUser()
        {
            throw new NotImplementedException();
        }
    }
}