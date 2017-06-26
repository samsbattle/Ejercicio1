using System;
using System.Data.Entity;
using System.Linq;

namespace GestionUsuarios.Models 
{
    public class EFUsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }


        public EFUsuarioContext() : base("name=Usuario_BD")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region USUARIO
            modelBuilder.Entity<Usuario>()
                .Property(u => u.Nombre).HasMaxLength(100);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.ApellidoPaterno).HasMaxLength(100);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.ApellidoMaterno).HasMaxLength(100);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Direccion).HasMaxLength(200);
            #endregion

        }
    }
}