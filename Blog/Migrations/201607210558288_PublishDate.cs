namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PublishDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.myDetaisl", "PublishedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.myDetaisl", "PublishedDate");
        }
    }
}
