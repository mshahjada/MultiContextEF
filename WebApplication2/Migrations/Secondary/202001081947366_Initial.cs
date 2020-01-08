namespace WebApplication2.Migrations.Secondary
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "po.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vendor = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("config.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            //CreateTable(
            //    "config.Products",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("po.Purchases", "ProductId", "config.Products");
            DropIndex("po.Purchases", new[] { "ProductId" });
            DropTable("config.Products");
            DropTable("po.Purchases");
        }
    }
}
