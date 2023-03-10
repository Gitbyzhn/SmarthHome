using SmarthHome.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmarthHome.Models.ViewModels
{
    public class IndexModel
    {
        public string UserName { get; set; }
        public IndexRooms Rooms { get; set; }
    }

    public class IndexRooms{
    
        public bool Living { get; set; }
        public bool Bed { get; set; }
        public bool Bath { get; set; }
        public bool Dining { get; set; }

    }
}