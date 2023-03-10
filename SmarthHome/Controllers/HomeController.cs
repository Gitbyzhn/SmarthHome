using SmarthHome.Models;
using SmarthHome.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmarthHome.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var user = db.Users.AsQueryable().SingleOrDefault(e => e.UserName == User.Identity.Name);

            var rooms = db.UserRooms.AsQueryable().Where(e => e.UserId == user.UserId).Select(e => e.RoomId).ToList();

            IndexModel result = new IndexModel()
            {
                UserName = user.SureName + " " + user.Name,
                Rooms = new IndexRooms {
                    Living = rooms.Contains(1),
                    Bed = rooms.Contains(2),    
                    Bath = rooms.Contains(3),
                    Dining = rooms.Contains(4)
                    
                }

            };

            return View(result);
        }

        public ActionResult Living()
        {
            ViewBag.PageName = "Living";


            var user = db.Users.AsQueryable().SingleOrDefault(e => e.UserName == User.Identity.Name);

            var devices = db.UserRoomDevices.AsQueryable().Where(e => e.UserId == user.UserId && e.RoomId == 1).ToList();

            RoomModel model = new RoomModel()
            {
                UserName = user.SureName + " " + user.Name,
            };

            foreach (var device in devices)
            {
                if (device.DeviceId == 1)
                {
                    model.Devices.Camera = new Camera()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 2)
                {
                    model.Devices.Light = new Light()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 3)
                {
                    model.Devices.Conditioner = new Conditioner()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 4)
                {
                    model.Devices.Curtains = new Curtains()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 5)
                {
                    model.Devices.TV = new TV()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

            }



            return View(model);
        }

        public ActionResult Bed()
        {
            ViewBag.PageName = "Bed";


            var user = db.Users.AsQueryable().SingleOrDefault(e => e.UserName == User.Identity.Name);

         
            var devices = db.UserRoomDevices.AsQueryable().Where(e => e.UserId == user.UserId && e.RoomId ==2).ToList();

            RoomModel model = new RoomModel()
            {
                UserName = user.SureName + " " + user.Name,
            };

            foreach (var device in devices)
            {
                if (device.DeviceId == 1)
                {
                    model.Devices.Camera = new Camera()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 2)
                {
                    model.Devices.Light = new Light()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 3)
                {
                    model.Devices.Conditioner = new Conditioner()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 4)
                {
                    model.Devices.Curtains = new Curtains()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 5)
                {
                    model.Devices.TV = new TV()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

            }


            ViewBag.PageName = "Bed";

            return View(model);
        }

        public ActionResult Bath()
        {

            ViewBag.PageName = "Bath";


            var user = db.Users.AsQueryable().SingleOrDefault(e => e.UserName == User.Identity.Name);
            var devices = db.UserRoomDevices.AsQueryable().Where(e => e.UserId == user.UserId && e.RoomId == 3).ToList();

            RoomModel model = new RoomModel()
            {
                UserName = user.SureName + " " + user.Name,
            };

            foreach (var device in devices)
            {
                if (device.DeviceId == 1)
                {
                    model.Devices.Camera = new Camera()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 2)
                {
                    model.Devices.Light = new Light()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 3)
                {
                    model.Devices.Conditioner = new Conditioner()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 4)
                {
                    model.Devices.Curtains = new Curtains()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 5)
                {
                    model.Devices.TV = new TV()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

            }

            ViewBag.PageName = "Bath";

            return View(model);
        }

        public ActionResult Dining()
        {

            ViewBag.PageName = "Dining";


            var user = db.Users.AsQueryable().SingleOrDefault(e => e.UserName == User.Identity.Name);

            var devices = db.UserRoomDevices.AsQueryable().Where(e => e.UserId == user.UserId && e.RoomId == 4).ToList();

            RoomModel model = new RoomModel()
            {
                UserName = user.SureName + " " + user.Name,
            };

            foreach (var device in devices)
            {
                if (device.DeviceId == 1)
                {
                    model.Devices.Camera = new Camera()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 2)
                {
                    model.Devices.Light = new Light()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 3)
                {
                    model.Devices.Conditioner = new Conditioner()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 4)
                {
                    model.Devices.Curtains = new Curtains()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

                if (device.DeviceId == 5)
                {
                    model.Devices.TV = new TV()
                    {
                        IsActive = device.IsActive,
                        Connect = device.Connect,

                    };
                }

            }

           
            ViewBag.PageName = "Dining";

            return View(model);
        }


        


    }
}