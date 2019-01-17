namespace MiniFootball.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 30),
                        Password = c.String(maxLength: 30),
                        Name = c.String(maxLength: 30),
                        Surname = c.String(maxLength: 30),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Surname = c.String(maxLength: 30),
                        Email = c.String(maxLength: 30),
                        Password = c.String(maxLength: 30),
                        BirthDate = c.DateTime(nullable: false),
                        Postion = c.String(maxLength: 30),
                        RoleId = c.Int(nullable: false),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.Email, unique: true)
                .Index(t => t.RoleId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PlayerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        EstablishmentDate = c.DateTime(nullable: false),
                        Logo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Skills", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.Players", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Administrations", "RoleId", "dbo.Roles");
            DropIndex("dbo.Skills", new[] { "PlayerId" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Players", new[] { "RoleId" });
            DropIndex("dbo.Players", new[] { "Email" });
            DropIndex("dbo.Administrations", new[] { "RoleId" });
            DropIndex("dbo.Administrations", new[] { "Email" });
            DropTable("dbo.Teams");
            DropTable("dbo.Skills");
            DropTable("dbo.Players");
            DropTable("dbo.Roles");
            DropTable("dbo.Administrations");
        }
    }
}
