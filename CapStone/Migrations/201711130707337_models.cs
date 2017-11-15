namespace CapStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.barbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        phoneNumber = c.String(),
                        specialty = c.String(),
                        workDays = c.String(),
                        workHours = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Barbershops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        prices = c.String(),
                        hours = c.String(),
                        holyday = c.String(),
                        phoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Barbershops");
            DropTable("dbo.barbers");
        }
    }
}
