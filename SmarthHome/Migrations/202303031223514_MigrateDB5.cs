namespace SmarthHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB5 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.UserRoomDevices", "DeviceId");
            CreateIndex("dbo.UserRooms", "RoomId");
            AddForeignKey("dbo.UserRoomDevices", "DeviceId", "dbo.Devices", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRooms", "RoomId", "dbo.Rooms", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRooms", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.UserRoomDevices", "DeviceId", "dbo.Devices");
            DropIndex("dbo.UserRooms", new[] { "RoomId" });
            DropIndex("dbo.UserRoomDevices", new[] { "DeviceId" });
        }
    }
}
