using System;
using System.Text.RegularExpressions;

namespace CatalogoProdutos.Domain
{
    public class Usuario
    {

        protected Usuario()
        {

        }

        public Usuario(
            string nome,
            string email,
            string usuarioAcesso,
            string senha)
        {

            //Contract.Requires<Exception>(nome.Length > 3, "Nome Invalido");

            //TODO: Criar uma classe para validar esses testes
            if (nome.Length < 3)
                throw new System.Exception("O nome deve ser maior que 3 caracteres");

            if (!Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$"))
                throw new System.Exception("O email deve ser valido");



        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Imagem { get; set; }
        public string UsuarioAcesso { get; set; }
        public string Senha { get; set; }

    }
}
