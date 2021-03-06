namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(),
                        Red = c.Int(nullable: false),
                        Green = c.Int(nullable: false),
                        Blue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        PhotoPath = c.String(),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.DateTime(nullable: false),
                        Score1 = c.Int(nullable: false),
                        Score2 = c.Int(nullable: false),
                        Team1Id = c.Int(nullable: false),
                        Team2Id = c.Int(nullable: false),
                        Result = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team1Id)
                .ForeignKey("dbo.Teams", t => t.Team2Id)
                .Index(t => t.Team1Id)
                .Index(t => t.Team2Id);
            
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        Team_Id = c.Int(nullable: false),
                        Color_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_Id, t.Color_Id })
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.Color_Id, cascadeDelete: true)
                .Index(t => t.Team_Id)
                .Index(t => t.Color_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team1Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamColors", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.TeamColors", "Team_Id", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "Color_Id" });
            DropIndex("dbo.TeamColors", new[] { "Team_Id" });
            DropIndex("dbo.Matches", new[] { "Team2Id" });
            DropIndex("dbo.Matches", new[] { "Team1Id" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropTable("dbo.TeamColors");
            DropTable("dbo.Matches");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Colors");
        }
    }
}
