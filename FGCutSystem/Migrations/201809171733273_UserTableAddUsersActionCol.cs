namespace FGCutSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableAddUsersActionCol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "CreatedBy", c => c.String(unicode: false));
            AddColumn("dbo.Users", "CreatedDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.Users", "UpdatedBy", c => c.String(unicode: false));
            AddColumn("dbo.Users", "UpdatedDate", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UpdatedDate");
            DropColumn("dbo.Users", "UpdatedBy");
            DropColumn("dbo.Users", "CreatedDate");
            DropColumn("dbo.Users", "CreatedBy");
        }
    }
}
