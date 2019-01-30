namespace Golden_Dragon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixThatDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PricesModels", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PricesModels", "Date", c => c.DateTime(nullable: false));
        }
    }
}
