namespace SmarthHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.UserRoomDevices", "RoomId");
            AddForeignKey("dbo.UserRoomDevices", "RoomId", "dbo.Rooms", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoomDevices", "RoomId", "dbo.Rooms");
            DropIndex("dbo.UserRoomDevices", new[] { "RoomId" });
        }
    }
}
