using SmarthHome.Models;
using SmarthHome.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmarthHome.API
{
    [Authorize]
    public class RoomDeviceControllController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public IHttpActionResult Post(int RoomId,int DeviceId,bool IsActive) {

            var user = db.Users.SingleOrDefault(e => e.UserName == e.UserName);
            UserRoomDevice userRoomDevice = db.UserRoomDevices.SingleOrDefault(e => e.UserId == user.UserId && e.DeviceId == DeviceId && e.RoomId == RoomId);
            userRoomDevice.IsActive = IsActive;
            db.SaveChanges();
            return Ok();

        }


        [AllowAnonymous]
        public IHttpActionResult Get(string USER_ID, int RoomId, int DeviceId, bool IsActive)
        {

            var user = db.Users.Find(USER_ID);

            if (user == null)
            {
                return NotFound();
            }

            UserRoomDevice userRoomDevice = db.UserRoomDevices.SingleOrDefault(e => e.UserId == user.UserId && e.DeviceId == DeviceId && e.RoomId == RoomId);

            userRoomDevice.Connect = IsActive;
            db.SaveChanges();
            return Ok();
        }

    }
}
