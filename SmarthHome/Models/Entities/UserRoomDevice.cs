using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmarthHome.Models.Entities
{
    public class UserRoomDevice
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public int DeviceId { get; set; }

        public bool IsActive { get; set; }
        public bool Connect { get; set; }

        public Room Room { get; set; }
        

        public virtual Device Device { get; set; }  
    }
}