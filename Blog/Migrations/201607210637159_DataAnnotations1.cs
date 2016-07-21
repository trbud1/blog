namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.myDetaisl", "Title", c => c.String(maxLength: 254));
            AlterColumn("dbo.myDetaisl", "Message", c => c.String(nullable: false, maxLength: 254));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.myDetaisl", "Message", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.myDetaisl", "Title", c => c.String(maxLength: 255));
        }
    }
}
