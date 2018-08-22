
namespace CatalogoProdutos.Web.CustomAttributes
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple = true)]
    public class AutorAttribute : System.Attribute
    {
        public string Nome { get; private set; }
        public double Versao { get; set; }

        public AutorAttribute(string nome)
        {
            Nome = nome;
            Versao = 1.0;
        }
    }
}
