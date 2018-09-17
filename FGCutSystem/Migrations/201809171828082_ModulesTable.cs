namespace FGCutSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModulesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemModules",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        Codigo = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, unique: true, name: "ModuleNameIndex")
                .Index(t => t.Codigo, unique: true, name: "ModuleCodeIndex")
                .Index(t => t.Activo, unique: true, name: "MoudleActiveIndex");
            
            CreateIndex("dbo.Users", "UserId", unique: true, name: "UserNameIndex");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", "UserNameIndex");
            DropIndex("dbo.SystemModules", "MoudleActiveIndex");
            DropIndex("dbo.SystemModules", "ModuleCodeIndex");
            DropIndex("dbo.SystemModules", "ModuleNameIndex");
            DropTable("dbo.SystemModules");
        }
    }
}
