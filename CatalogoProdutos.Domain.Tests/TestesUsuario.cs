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
        public void O_Usuario_deve_conter_o_nome()
        {
            var usuario = new Usuario(nome: "",email:"joao91.nascimento@gmail.com",usuarioAcesso:"joaozinho",senha: "1234");
        }


        [TestMethod]
        [TestCategory("Novo usuário")]
        [ExpectedException(typeof(Exception),noExceptionMessage: "O email deve ser informado.Tratar erro")]
        public void O_Usuario_deve_conter_o_email()
        {
            var usuario = new Usuario(nome: "joao", email: "joao91.nascimento@2@sasgmail.com.br.br", usuarioAcesso: "joaozinho", senha: "1234");
        }


        [TestMethod]
        [TestCategory("Novo usuário")]
        [ExpectedException(typeof(Exception), noExceptionMessage: "O usuario de acesso deve ser informado.Tratar erro")]
        public void O_Usuario_deve_conter_o_usuario_de_acesso()
        {
            var usuario = new Usuario(nome: "joao", email: "joao91.nascimento@gmail.com", usuarioAcesso: "", senha: "1234");
        }


        [TestMethod]
        [TestCategory("Novo usuário")]
        [ExpectedException(typeof(Exception), noExceptionMessage: "A senha deve ser informado.Tratar erro")]
        public void O_Usuario_deve_conter_a_senha()
        {
            var usuario = new Usuario(nome: "joao", email: "joao91.nascimento@gmail.com", usuarioAcesso: "joaozinho", senha: "");
        }
    }
}
