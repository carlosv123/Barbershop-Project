namespace CapStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Models1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Barbers");
            DropTable("dbo.Barbershops");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Barbershops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        prices = c.Int(nullable: false),
                        hours = c.String(),
                        holydayHours = c.String(),
                        phoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Barbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        specialty = c.String(),
                        phoneNumber = c.String(),
                        WorkDays = c.String(),
                        WorkHours = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
