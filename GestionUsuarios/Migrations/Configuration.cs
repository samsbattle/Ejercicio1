namespace GestionUsuarios.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GestionUsuarios.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GestionUsuarios.Models.EFUsuarioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFUsuarioContext context)
        {

            context.Usuario.AddOrUpdate(
              new Usuario { Id= 1, Nombre="Samuel", ApellidoPaterno="Duran", ApellidoMaterno="Becerril", Direccion=" Valle del tarim 14", Telefono="5564239902"},
              new Usuario { Id = 2, Nombre = "Juan", ApellidoPaterno = "Perez", ApellidoMaterno = "Gomez", Direccion = "Av central s/n", Telefono = "5557113005" },
              new Usuario { Id = 3, Nombre = "Gabriel", ApellidoPaterno = "Gonzalez", ApellidoMaterno = "Ramirez", Direccion = "Avenida Maravillas", Telefono = "5556581111" }
            );

        }
    }
}
