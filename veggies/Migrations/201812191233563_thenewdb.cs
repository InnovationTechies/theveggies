namespace veggies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thenewdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCatagories",
                c => new
                    {
                        catagoryID = c.Int(nullable: false, identity: true),
                        CatagoryName = c.String(unicode: false),
                        CatagoryDesc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.catagoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(unicode: false),
                        ProductPrice = c.Single(nullable: false),
                        ProductImage = c.Binary(),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.ProductCatagories");
        }
    }
}
