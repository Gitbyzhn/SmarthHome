using Microsoft.AspNet.Identity.EntityFramework;
using SmarthHome.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmarthHome.Models
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
           : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        public DbSet<Room> Rooms { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<UserRoomDevice> UserRoomDevices { get; set; }
        public DbSet<UserRoom> UserRooms { get; set; }
    }
}