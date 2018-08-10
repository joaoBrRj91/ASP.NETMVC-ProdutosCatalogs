using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalogoProdutos.Domain.Tests
{
    [TestClass]
    public class Dado_um_novo_usuario
    {
        [TestMethod]
        [TestCategory("Novo usuário")]
        [ExpectedException(typeof(Exception), noExceptionMessage: "O nome deve ser valido.Tratar erro")]
        public void O_Usuario_deve_conter_o_nome_valido()
        {
            var usuario = new Usuario(nome: "",email:"joao91.nascimento@gmail.com",usuarioAcesso:"joaozinho",senha: "12345679");
        }


        [TestMethod]
        [TestCategory("Novo usuário")]
        [ExpectedException(typeof(Exception),noExceptionMessage: "O email deve ser informado.Tratar erro")]
        public void O_Usuario_deve_conter_o_email_valido()
        {
            var usuario = new Usuario(nome: "joao", email: "joao91.nascimento@@gmail.com.br", usuarioAcesso: "joaozinho", senha: "123464654");
        }


        [TestMethod]
        [TestCategory("Novo usuário")]
        [ExpectedException(typeof(Exception), noExceptionMessage: "O usuario de acesso deve ser informado.Tratar erro")]
        public void O_Usuario_deve_conter_o_usuario_de_acesso_valido()
        {
            var usuario = new Usuario(nome: "joao", email: "joao91.nascimento@gmail.com", usuarioAcesso: "", senha: "1245646534");
        }


        [TestMethod]
        [TestCategory("Novo usuário")]
        [ExpectedException(typeof(Exception), noExceptionMessage: "A senha deve ser informado.Tratar erro")]
        public void O_Usuario_deve_conter_a_senha_valido()
        {
            var usuario = new Usuario(nome: "joao", email: "joao91.nascimento@gmail.com", usuarioAcesso: "joaozinho", senha: "");
        }
    }

    [TestClass]
    public class Ao_alterar_os_dados_do_usuario
    {
        [TestMethod]
        [TestCategory("Alterar E-mail")]
        [ExpectedException(typeof(Exception), noExceptionMessage: "O novo email deve ser validado.Tratar erro")]
        public void O_novo_email_deve_ser_valido()
        {
            var usuario = new Usuario(nome: "joao nascimento", email: "joao91.nascimento@gmail.com", usuarioAcesso: "joaozinho", senha: "12345789");
            usuario.AlterarEmail("joao91.nascimentogmail.com.br");
        }

        [TestMethod]
        [TestCategory("Alterar Senha")]
        [ExpectedException(typeof(Exception), noExceptionMessage: "A nova senha deve ser validada.Tratar erro")]
        public void O_usuario_e_a_nova_senham_deve_ser_validos()
        {
            var usuario = new Usuario(nome: "joao nascimento", email: "joao91.nascimento@gmail.com", usuarioAcesso: "joaozinho", senha: "12345789");
            usuario.AlterarSenha("joaozinho2", "12345789", "123457894", "123457894");
        }

    }

}
