using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmarthHome.Models.API
{
    public class RoomResponse
    {
        public Device Devices { get; set; }
    }

    public class Device
    {
        public Light Light { get; set; } = null;

        public Conditioner Conditioner { get; set; } = null;

        public Curtains Curtains { get; set; } = null;

        public TV TV { get; set; } = null;

    }


    public class Light
    {
        public bool IsActive { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

    }


    public class Conditioner
    {
        public bool IsActive { get; set; }
    }

    public class Curtains {
        public bool IsActive { get; set; }
    }

    public class TV {
        public bool IsActive { get; set; }
    }

}