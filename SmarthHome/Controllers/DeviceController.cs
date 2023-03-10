using Microsoft.Ajax.Utilities;
using SmarthHome.Models;
using SmarthHome.Models.Entities;
using SmarthHome.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmarthHome.Controllers
{
    public class DeviceController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Device
        public ActionResult Index(int RoomId)
        {
            var user = db.Users.SingleOrDefault(e => e.UserName == User.Identity.Name);

            var room = db.Rooms.Find(RoomId);

            var userRoomDevices = db.UserRoomDevices.Where(e => e.UserId == user.UserId && e.RoomId == RoomId).ToList();

            DeviceAddModel model = new DeviceAddModel() { DeviceIds = userRoomDevices.Select(e => e.DeviceId).ToList() };

            ViewBag.PageName = room.Name;

            return View(model);
        }


        [HttpPost]
        public ActionResult Index(string[] Devices,int RoomId)
        {

            var user = db.Users.SingleOrDefault(e => e.UserName == User.Identity.Name);

            var room = db.Rooms.Find(RoomId);

            var userRoomDevices = db.UserRoomDevices.Where(e => e.UserId == user.UserId && e.RoomId == RoomId).ToList();


            db.UserRoomDevices.RemoveRange(userRoomDevices);

            userRoomDevices.Clear();

            Devices.ForEach(e => userRoomDevices.Add(new UserRoomDevice { UserId = user.UserId, RoomId = RoomId, DeviceId = int.Parse(e),IsActive = false }));

            db.UserRoomDevices.AddRange(userRoomDevices);
            db.SaveChanges();


            DeviceAddModel model = new DeviceAddModel() { DeviceIds = userRoomDevices.Select(e => e.DeviceId).ToList() };

            ViewBag.PageName = room.Name;

            return View(model);

         
        }
    }
}