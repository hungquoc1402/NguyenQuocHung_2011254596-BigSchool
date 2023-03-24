namespace NguyenQuocHung_B6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FollowedId = c.String(nullable: false, maxLength: 128),
                        FollowedeId = c.String(nullable: false, maxLength: 128),
                        Followee_Id = c.String(maxLength: 128),
                        Follower_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FollowedId, t.FollowedeId })
                .ForeignKey("dbo.AspNetUsers", t => t.Followee_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Follower_Id)
                .Index(t => t.Followee_Id)
                .Index(t => t.Follower_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followings", "Follower_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "Followee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "Follower_Id" });
            DropIndex("dbo.Followings", new[] { "Followee_Id" });
            DropTable("dbo.Followings");
        }
    }
}
