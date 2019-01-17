namespace MiniFootball.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminModelAndPlayerModelChanged : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Players", new[] { "Email" });
            AlterColumn("dbo.Players", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Players", "Surname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Players", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Players", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Players", "Postion", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Players", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Players", new[] { "Email" });
            AlterColumn("dbo.Players", "Postion", c => c.String(maxLength: 30));
            AlterColumn("dbo.Players", "Password", c => c.String(maxLength: 30));
            AlterColumn("dbo.Players", "Email", c => c.String(maxLength: 30));
            AlterColumn("dbo.Players", "Surname", c => c.String(maxLength: 30));
            AlterColumn("dbo.Players", "Name", c => c.String(maxLength: 30));
            CreateIndex("dbo.Players", "Email", unique: true);
        }
    }
}
