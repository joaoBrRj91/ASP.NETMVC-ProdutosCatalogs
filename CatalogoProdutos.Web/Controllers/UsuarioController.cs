using CatalogoProdutos.Domain;
using CatalogoProdutos.Domain.Repositories;
using CatalogoProdutos.Web.Models.Usuario;
using System.Web.Mvc;

namespace CatalogoProdutos.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        //TODO: Alterar para retornar o listaUsuarioViewModel
        public ActionResult Index()
        {
            return View(_usuarioRepository.ObterDados());
        }

        public ActionResult CriarUsuario()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CriarUsuario(CriacaoUsuarioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["invalido"] = "Existem informações inválidas";
                ModelState.AddModelError("DefaultErroMessage", "Ocorreu um erro ao realizar a operação");
                return View(model);
            }

            try
            {
                var usuario = new Usuario(model.Nome, model.Email, model.UsuarioAcesso, model.Senha);
                usuario.Registrar(model.Email, model.UsuarioAcesso, model.Senha, model.ConfirmarSenha);
                _usuarioRepository.SalvarOuAtualizar(usuario);

            }
            catch (System.Exception ex)
            {
                TempData["invalido"] = ex.Message;
                return View(model);
            }

            TempData["valido"] = "Usuário cadastrado com sucesso!!";
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _usuarioRepository.Dispose();
        }
    }
}