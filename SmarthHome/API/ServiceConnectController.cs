using Microsoft.Ajax.Utilities;
using SmarthHome.Models;
using SmarthHome.Models.API;
using SmarthHome.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace SmarthHome.API
{
    public class ServiceConnectController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        public IHttpActionResult Post(string USER_ID) {

            var user = db.Users.Find(USER_ID);

            if (user == null)
            {
                return NotFound();
            }

            var userRooms = db.UserRooms.Where(e => e.UserId == user.UserId).ToList();

            var userRoomDevice = db.UserRoomDevices.Where(e => e.UserId == user.UserId).ToList();

            ServiceConnectResponse response = new ServiceConnectResponse() {
                UserName = user.UserName,
                Rooms = new List<UserRoomAPI>() { }
                


            };

            foreach (var userRoom in userRooms)
            {

                UserRoomAPI room = new UserRoomAPI() { RoomId = userRoom.RoomId, RoomName = userRoom.Room.Name, Devices  = new List<UserDevicesAPI>() { } };

                userRoomDevice.Where(e => e.RoomId == userRoom.RoomId).
                    ForEach(e => room.Devices.Add(new UserDevicesAPI { DeviceId = e.DeviceId, DeviceName = e.Device.Name, IsActive = e.IsActive }));

                response.Rooms.Add(room);


            }



            return Ok(response);

        }
    }
}
