namespace FGCutSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModulesRemoveIndexActive : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SystemModules", "MoudleActiveIndex");
        }
        
        public override void Down()
        {
            CreateIndex("dbo.SystemModules", "Activo", unique: true, name: "MoudleActiveIndex");
        }
    }
}
