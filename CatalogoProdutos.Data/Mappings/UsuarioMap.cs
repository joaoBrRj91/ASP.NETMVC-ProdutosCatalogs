using CatalogoProdutos.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace CatalogoProdutos.Data.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            #region Tabela
            ToTable("usuario");
            #endregion

            #region Relacionamentos
            HasKey(i => i.Id);
            #endregion

            #region Propriedades

            Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("email")
                .HasColumnAnnotation(
                      "Index",
                       new IndexAnnotation(
                            new IndexAttribute("IX_USUARIO_EMAIL")
                            {
                                IsUnique = true
                            }));

            Property(e => e.UsuarioAcesso)
              .IsRequired()
              .HasMaxLength(20)
              .HasColumnName("usuario_acesso")
              .HasColumnAnnotation(
                     "Index",
                      new IndexAnnotation(
                           new IndexAttribute("IX_USUARIO_ACESSO")
                           {
                               IsUnique = true
                           }));


            Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("nome");

            Property(e => e.Senha)
               .IsRequired()
               .HasMaxLength(20)
               .IsFixedLength()
               .HasColumnName("senha");

            #endregion

        }
    }
}
