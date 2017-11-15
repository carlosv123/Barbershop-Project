namespace CapStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false),
                        lastName = c.String(nullable: false),
                        age = c.Int(nullable: false),
                        email = c.String(nullable: false),
                        Time = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                        payment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.payments", t => t.payment_Id)
                .Index(t => t.payment_Id);
            
            CreateTable(
                "dbo.payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        amount = c.Double(nullable: false),
                        paymentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.paymentTypes", t => t.paymentType_Id)
                .Index(t => t.paymentType_Id);
            
            CreateTable(
                "dbo.paymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.appointments", "payment_Id", "dbo.payments");
            DropForeignKey("dbo.payments", "paymentType_Id", "dbo.paymentTypes");
            DropIndex("dbo.payments", new[] { "paymentType_Id" });
            DropIndex("dbo.appointments", new[] { "payment_Id" });
            DropTable("dbo.paymentTypes");
            DropTable("dbo.payments");
            DropTable("dbo.appointments");
        }
    }
}
