namespace FGCutSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        Apellido = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        UserId = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Password = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        ConfirmPassword = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Lastlogin = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
