using System.Data.Entity;
using CatalogoProdutos.Data.Mappings;
using CatalogoProdutos.Domain;

namespace CatalogoProdutos.Data.DataContexts
{
    public class CatalogoDataContext : DbContext
    {
        public CatalogoDataContext() : base("CatalogoSqlServerDbContext")
        {  }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
