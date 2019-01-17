namespace MiniFootball.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredAttributeAddedAllModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Skills", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Teams", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Teams", "Logo", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Logo", c => c.Binary());
            AlterColumn("dbo.Teams", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Skills", "Name", c => c.String());
            AlterColumn("dbo.Roles", "Name", c => c.String(maxLength: 30));
        }
    }
}
