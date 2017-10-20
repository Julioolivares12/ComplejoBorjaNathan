namespace ComplejoBorjaNathan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacionTodasLasTablassYRelaciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Archivos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombreArchivo = c.String(nullable: false),
                        urlArchivo = c.String(nullable: false),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Aulas",
                c => new
                    {
                        id = c.Int(nullable: false),
                        nombreAula = c.String(),
                        Inscripciones_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Archivos", t => t.id)
                .ForeignKey("dbo.Inscripciones", t => t.Inscripciones_id)
                .Index(t => t.id)
                .Index(t => t.Inscripciones_id);
            
            CreateTable(
                "dbo.Inscripciones",
                c => new
                    {
                        id = c.Int(nullable: false),
                        ApliacionUsers_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApliacionUsers_Id)
                .ForeignKey("dbo.Materias", t => t.id)
                .Index(t => t.id)
                .Index(t => t.ApliacionUsers_Id);
            
            CreateTable(
                "dbo.Publicaciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        titulo = c.String(nullable: false, maxLength: 100),
                        descripcion = c.String(nullable: false, maxLength: 200),
                        cuerpo = c.String(nullable: false),
                        imagenUrl = c.String(nullable: false),
                        fecha = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        TipoPublicacion_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.TipoPublicacions", t => t.TipoPublicacion_id)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.TipoPublicacion_id);
            
            CreateTable(
                "dbo.TipoPublicacions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tipoPublicacion = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        materia = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.AspNetUsers", "Apellido", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscripciones", "id", "dbo.Materias");
            DropForeignKey("dbo.Aulas", "Inscripciones_id", "dbo.Inscripciones");
            DropForeignKey("dbo.Inscripciones", "ApliacionUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Publicaciones", "TipoPublicacion_id", "dbo.TipoPublicacions");
            DropForeignKey("dbo.Publicaciones", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Aulas", "id", "dbo.Archivos");
            DropIndex("dbo.Publicaciones", new[] { "TipoPublicacion_id" });
            DropIndex("dbo.Publicaciones", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Inscripciones", new[] { "ApliacionUsers_Id" });
            DropIndex("dbo.Inscripciones", new[] { "id" });
            DropIndex("dbo.Aulas", new[] { "Inscripciones_id" });
            DropIndex("dbo.Aulas", new[] { "id" });
            DropColumn("dbo.AspNetUsers", "Apellido");
            DropTable("dbo.Materias");
            DropTable("dbo.TipoPublicacions");
            DropTable("dbo.Publicaciones");
            DropTable("dbo.Inscripciones");
            DropTable("dbo.Aulas");
            DropTable("dbo.Archivos");
        }
    }
}
