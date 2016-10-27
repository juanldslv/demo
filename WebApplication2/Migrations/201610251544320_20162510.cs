namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20162510 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.States", "Descripcion", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.States", "Descripcion", c => c.String());
        }
    }
}
