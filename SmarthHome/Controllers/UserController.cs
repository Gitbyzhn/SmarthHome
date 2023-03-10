using SmarthHome.Models;
using SmarthHome.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmarthHome.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: User
        public ActionResult Account()
        {
            var user = db.Users.SingleOrDefault(e => e.UserName == User.Identity.Name);

            UserAccountModel model = new UserAccountModel()
            {
                UserId = user.Id,
                Email = user.Email,
                UserName = user.Name + " " + user.SureName

            };
            return View(model);
        }
    }
}