namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomers1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BasketItems", "Quanity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BasketItems", "Quanity");
        }
    }
}
