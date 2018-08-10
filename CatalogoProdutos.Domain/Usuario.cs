using System.Text.RegularExpressions;

namespace CatalogoProdutos.Domain
{
    //TODO: Criar uma classe para validar esses testes semelhante ao Contracts - Refatoração para uma classe de validação
    public class Usuario
    {
        #region Construtores
        protected Usuario()
        {

        }

        public Usuario(string nome, string email, string usuarioAcesso, string senha)
        {

            //Contract.Requires<Exception>(nome.Length > 3, "Nome Invalido");
   
            if (nome.Length < 3)
                throw new System.Exception("O nome deve ser no minimo 3 caracteres");

            if (!Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                throw new System.Exception("O email deve ser valido");

            if (usuarioAcesso.Length < 8)
                throw new System.Exception("O usuário de acesso deve ser no minimo 8 caracteres");

            if (senha.Length < 6)
                throw new System.Exception("A senha deve ser no minimo 6 caracteres");

            Id = 0;
            Nome = nome;
            Email = email;
            UsuarioAcesso = usuarioAcesso;
            Senha = senha;
        }
        #endregion

        #region Propriedades
        public int Id  { get; protected set; }
        public string Nome  { get; protected set; }
        public string Email { get; protected set; }
        public string UsuarioAcesso { get; protected set; }
        public string Senha { get; protected set; }
        #endregion

        #region Métodos Públicos

        public void AlterarEmail(string email)
        {
           if (!Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                throw new System.Exception("O email deve ser valido");
            Email = email;
        }


        public void AlterarSenha(string usuarioAcesso, string senha, string novaSenha,string confirmacaoSenha)
        {
            //TODO: Fazer um cenario de teste para cada if : METODO AlterarSenha
            if (!UsuarioAcesso.Equals(usuarioAcesso, System.StringComparison.InvariantCultureIgnoreCase) || !Senha.Equals(senha))
                throw new System.Exception("Usuário ou senha incorretos");

            if(Senha.Equals(novaSenha))
                throw new System.Exception("Nova senha deve ser diferente da atual");

            if (senha.Length < 6)
                throw new System.Exception("A senha deve ser no minimo 6 caracteres");

            if(!novaSenha.Equals(confirmacaoSenha))
                throw new System.Exception("As senhas digitadas não coincidem");

            Senha = novaSenha;
        }

        public void Autenticar(string usuarioAcesso, string senha)
        {
            if (!UsuarioAcesso.Equals(usuarioAcesso, System.StringComparison.InvariantCultureIgnoreCase) || !Senha.Equals(senha))
                throw new System.InvalidOperationException("Usuário ou senha incorretos");
        }

        public void Registrar(string nome, string email, string usuarioAcesso, string senha, string confirmacaoSenha)
        {

            //TODO: Fazer um cenario de teste para cada if: METODO Registrar
            if (nome.Length < 3)
                throw new System.InvalidCastException("O nome deve ser no minimo 3 caracteres");

            if (!Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                throw new System.InvalidCastException("O email deve ser valido");

            if (usuarioAcesso.Length < 8)
                throw new System.InvalidCastException("O usuário de acesso deve ser no minimo 8 caracteres");

            if (senha.Length < 6)
                throw new System.InvalidCastException("A senha deve ser no minimo 6 caracteres");

            if (!senha.Equals(confirmacaoSenha))
                throw new System.InvalidCastException("As senhas digitadas não coincidem");
        }

        #endregion

    }
}
