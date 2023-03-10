using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmarthHome.Models.API
{
    public class ServiceConnectResponse
    {
        public string UserName { get; set; }

        public List<UserRoomAPI> Rooms { get; set; }


    }

    public class UserRoomAPI{

        public int RoomId { get; set; }
        public string RoomName { get; set; }

        public List<UserDevicesAPI> Devices { get; set; }

    }


    public class UserDevicesAPI { 
       public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public bool IsActive { get; set; }
    
    }
}