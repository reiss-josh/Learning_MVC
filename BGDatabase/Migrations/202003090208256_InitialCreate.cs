namespace BGDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameDesigners",
                c => new
                    {
                        GameDesignerID = c.Int(nullable: false, identity: true),
                        DesignerName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GameDesignerID);
            
            CreateTable(
                "dbo.BoardGames",
                c => new
                    {
                        BoardGameID = c.Int(nullable: false, identity: true),
                        GameName = c.String(nullable: false),
                        Weight = c.Single(),
                        PlayTime = c.Int(nullable: false),
                        GameDesignerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BoardGameID)
                .ForeignKey("dbo.GameDesigners", t => t.GameDesignerID, cascadeDelete: true)
                .Index(t => t.GameDesignerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BoardGames", "GameDesignerID", "dbo.GameDesigners");
            DropIndex("dbo.BoardGames", new[] { "GameDesignerID" });
            DropTable("dbo.BoardGames");
            DropTable("dbo.GameDesigners");
        }
    }
}
