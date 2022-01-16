﻿namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditingSomething : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamId" });
            AlterColumn("dbo.Players", "TeamId", c => c.Int());
            CreateIndex("dbo.Players", "TeamId");
            AddForeignKey("dbo.Players", "TeamId", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamId" });
            AlterColumn("dbo.Players", "TeamId", c => c.Int(nullable: false));
            CreateIndex("dbo.Players", "TeamId");
            AddForeignKey("dbo.Players", "TeamId", "dbo.Teams", "Id", cascadeDelete: true);
        }
    }
}
