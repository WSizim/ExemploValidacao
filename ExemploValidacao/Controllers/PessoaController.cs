using ExemploValidacao.Models;
using System.Web.Mvc;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa) ;
        }

        public ActionResult Sobre()
        {
            return View();
        }
                                           // public ActionResult LogInUnico { get; set; }
    }
}