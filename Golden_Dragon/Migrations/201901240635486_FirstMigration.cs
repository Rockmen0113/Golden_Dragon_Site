namespace Golden_Dragon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HotelRoomModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PricesModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        isSpecial = c.Boolean(nullable: false),
                        hotelRoom_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HotelRoomModels", t => t.hotelRoom_ID)
                .Index(t => t.hotelRoom_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PricesModels", "hotelRoom_ID", "dbo.HotelRoomModels");
            DropIndex("dbo.PricesModels", new[] { "hotelRoom_ID" });
            DropTable("dbo.PricesModels");
            DropTable("dbo.HotelRoomModels");
        }
    }
}
