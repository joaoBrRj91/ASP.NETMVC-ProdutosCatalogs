namespace CatalogoProdutos.Domain.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario ObterUsuarioPorUsuarioAcesso(string usuarioAcesso);
        Usuario ObterUsuarioPorUsuarioAcessoESenha(string usuarioAcesso, string senha);

    }
}
