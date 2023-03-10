using Microsoft.Ajax.Utilities;
using SmarthHome.Models;
using SmarthHome.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmarthHome.Controllers
{
    public class RoomController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Room
        public ActionResult Add()
        {

            var user = db.Users.SingleOrDefault(e => e.UserName == User.Identity.Name);

            var userRooms = db.UserRooms.Where(e => e.UserId == user.UserId).ToList();

            RoomAddModel model = new RoomAddModel() { RoomIds = userRooms.Select(e => e.RoomId).ToList() };

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(string[] Rooms)
        {

            var user = db.Users.SingleOrDefault(e => e.UserName == User.Identity.Name);

            var userRooms = db.UserRooms.Where(e => e.UserId == user.UserId).ToList();

            db.UserRooms.RemoveRange(userRooms);
            userRooms.Clear();

            Rooms.ForEach(e => userRooms.Add(new Models.Entities.UserRoom { UserId = user.UserId, RoomId = int.Parse(e) }));

            db.UserRooms.AddRange(userRooms);
            db.SaveChanges();


            RoomAddModel model = new RoomAddModel() { RoomIds = userRooms.Select(e => e.RoomId).ToList() };


            return View(model);
        }

    }
}