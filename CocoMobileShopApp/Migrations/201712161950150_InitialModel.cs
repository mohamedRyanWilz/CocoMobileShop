namespace CocoMobileShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Address = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        DateOfPay = c.DateTime(),
                        Value = c.Single(nullable: false),
                        Branch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.Branch_Id)
                .Index(t => t.Branch_Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 11),
                        Branch_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.Branch_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Role = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        NumInStock = c.Int(nullable: false),
                        BuyPrice = c.Single(nullable: false),
                        SalePrice = c.Single(nullable: false),
                        DateOfBuy = c.DateTime(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        NumOfItems = c.Int(nullable: false),
                        DateOfSale = c.DateTime(),
                        UserName = c.String(nullable: false),
                        CustomerName = c.String(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.UserBranches",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Branch_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Branch_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Branches", t => t.Branch_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Branch_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Phones", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserBranches", "Branch_Id", "dbo.Branches");
            DropForeignKey("dbo.UserBranches", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Phones", "Branch_Id", "dbo.Branches");
            DropForeignKey("dbo.Expenses", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.UserBranches", new[] { "Branch_Id" });
            DropIndex("dbo.UserBranches", new[] { "User_Id" });
            DropIndex("dbo.Transactions", new[] { "Product_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.Phones", new[] { "User_Id" });
            DropIndex("dbo.Phones", new[] { "Branch_Id" });
            DropIndex("dbo.Expenses", new[] { "Branch_Id" });
            DropTable("dbo.UserBranches");
            DropTable("dbo.Transactions");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Users");
            DropTable("dbo.Phones");
            DropTable("dbo.Expenses");
            DropTable("dbo.Branches");
        }
    }
}
