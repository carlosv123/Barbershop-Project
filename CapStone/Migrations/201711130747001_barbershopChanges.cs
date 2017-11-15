namespace CapStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class barbershopChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Barbershops", "Haircutprices", c => c.String());
            AddColumn("dbo.Barbershops", "Openhours", c => c.String());
            AddColumn("dbo.Barbershops", "OpenDays", c => c.String());
            AddColumn("dbo.Barbershops", "holdayDays", c => c.String());
            DropColumn("dbo.Barbershops", "prices");
            DropColumn("dbo.Barbershops", "hours");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Barbershops", "hours", c => c.String());
            AddColumn("dbo.Barbershops", "prices", c => c.String());
            DropColumn("dbo.Barbershops", "holdayDays");
            DropColumn("dbo.Barbershops", "OpenDays");
            DropColumn("dbo.Barbershops", "Openhours");
            DropColumn("dbo.Barbershops", "Haircutprices");
        }
    }
}
