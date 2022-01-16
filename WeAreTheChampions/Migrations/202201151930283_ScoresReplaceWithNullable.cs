namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScoresReplaceWithNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matches", "Score1", c => c.Int());
            AlterColumn("dbo.Matches", "Score2", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matches", "Score2", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "Score1", c => c.Int(nullable: false));
        }
    }
}
