using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmarthHome.Models.Entities
{
    public class UserRoom
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }

       
    }
}