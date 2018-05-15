namespace MvcTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aabb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Buwawa", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Buwawa");
        }
    }
}
