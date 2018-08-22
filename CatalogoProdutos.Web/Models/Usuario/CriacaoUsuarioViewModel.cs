
using CatalogoProdutos.Web.CustomAttributes;
using System.ComponentModel.DataAnnotations;

namespace CatalogoProdutos.Web.Models.Usuario
{
    [Autor(nome:"João Nascimento",Versao = 1.1)]
    public class CriacaoUsuarioViewModel
    {

        [Required(ErrorMessage ="Nome Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-mail Obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Usuario de Acesso Obrigatório")]
        public string UsuarioAcesso { get; set; }

        [Required(ErrorMessage = "Senha Obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Compare(otherProperty: "Senha",ErrorMessage ="Senhas não conferem")]
        [DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; }

    }
}