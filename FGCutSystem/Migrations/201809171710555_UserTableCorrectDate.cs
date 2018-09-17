namespace FGCutSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableCorrectDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Lastlogin", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Lastlogin", c => c.String(unicode: false));
        }
    }
}
