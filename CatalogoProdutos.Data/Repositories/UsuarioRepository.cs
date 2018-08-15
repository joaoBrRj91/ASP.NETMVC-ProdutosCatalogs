using System.Collections.Generic;
using CatalogoProdutos.Data.DataContexts;
using CatalogoProdutos.Domain;
using CatalogoProdutos.Domain.Repositories;
using System.Linq;
using System.Data.Entity;

namespace CatalogoProdutos.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private CatalogoDataContext catalogocontext;

        public UsuarioRepository(CatalogoDataContext catalogocontext)
        {
            this.catalogocontext = catalogocontext;
        }

        public Usuario ObterDado(int id) => catalogocontext.Usuarios.Find(id);
      

        public IEnumerable<Usuario> ObterDados() => catalogocontext.Usuarios;
      

        public Usuario ObterUsuarioPorUsuarioAcesso(string usuarioAcesso)
        {
            return catalogocontext
                   .Usuarios
                   .Where(u => u.UsuarioAcesso.ToLower().Equals(usuarioAcesso.ToLower()))
                   .FirstOrDefault();
        }

        public Usuario ObterUsuarioPorUsuarioAcessoESenha(string usuarioAcesso, string senha)
        {
            return catalogocontext
                   .Usuarios
                   .Where(u => u.UsuarioAcesso.ToLower().Equals(usuarioAcesso.ToLower()) && u.Senha.Equals(senha))
                   .FirstOrDefault();
        }

        public void SalvarOuAtualizar(Usuario entity)
        {
            if (entity.Id == 0)
                catalogocontext.Usuarios.Add(entity);
            else
                catalogocontext.Entry<Usuario>(entity).State = EntityState.Modified;

            catalogocontext.SaveChanges();
            Dispose();
            
        }

        public void Deletar(int id)
        {
            catalogocontext.Usuarios.Remove(catalogocontext.Usuarios.Find(id));
            Dispose();
        }

        public void Dispose()
        {
            if (catalogocontext != null)
                catalogocontext = null;
        }

    }
}
