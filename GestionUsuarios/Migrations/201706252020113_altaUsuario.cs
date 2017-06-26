namespace GestionUsuarios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altaUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        ApellidoMaterno = c.String(maxLength: 100),
                        ApellidoPaterno = c.String(maxLength: 100),
                        Telefono = c.String(),
                        Direccion = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
