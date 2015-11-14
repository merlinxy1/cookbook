namespace FirstApplicationInWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pictureUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "PictureUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "PictureUrl");
        }
    }
}
