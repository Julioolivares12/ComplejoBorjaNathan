namespace ComplejoBorjaNathan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nombre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Nombre");
        }
    }
}
