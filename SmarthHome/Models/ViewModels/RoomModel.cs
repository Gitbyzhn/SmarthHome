using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmarthHome.Models.ViewModels
{
    public class RoomModel
    {
        public string UserName { get; set; }

        public Devices Devices { get; set; } = new Devices();
    }

   

    public class Devices {


        public Camera Camera { get; set; } = null;
        public Light Light { get; set; } = null;

        public Bed Bed { get; set; } = null;

        public Conditioner Conditioner { get; set; } = null; 

        public Curtains Curtains { get; set; } = null;

        public TV TV { get; set; } = null; 
    }

    public class Camera{
    
        public bool IsActive { get; set; }
        public bool Connect { get; set; }
    }

    public class Light
    {

        public bool IsActive { get; set; }
        public bool Connect { get; set; }
    }

    public class Bed
    {

        public bool IsActive { get; set; }
        public bool Connect { get; set; }
    }
    public class Conditioner
    {

        public bool IsActive { get; set; }
        public bool Connect { get; set; }
    }
    public class Curtains
    {

        public bool IsActive { get; set; }
        public bool Connect { get; set; }
    }

    public class TV { 
       public bool IsActive { get; set; }
        public bool Connect { get; set; }
    
    }

}