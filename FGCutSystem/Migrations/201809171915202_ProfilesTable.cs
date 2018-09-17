namespace FGCutSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfilesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, unique: true, name: "ProfileNameIndex");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Profiles", "ProfileNameIndex");
            DropTable("dbo.Profiles");
        }
    }
}
