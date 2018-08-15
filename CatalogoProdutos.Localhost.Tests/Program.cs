using CatalogoProdutos.Data.DataContexts;
using System.Linq;

namespace CatalogoProdutos.Localhost.Tests
{
    class Program
    {
         private static CatalogoDataContext context = new CatalogoDataContext();

        static void Main(string[] args)
        {
            var usuariosPrimeiraConsulta = context.Usuarios.ToList();
            var usuariosSegundaConsulta = context.Usuarios.Where(n=>n.Nome.ToLower().Equals("joao")).ToList();

        }
    }
}
