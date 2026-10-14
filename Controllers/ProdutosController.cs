using Microsoft.AspNetCore.Mvc;
using TechStoremvc.Models;

namespace TechStoremvc.Controllers // o ":" significa herança
// Herança  = herda as caracteristicas de um controler. :)
// Conceitos de POO -> Programação Orientada a Objetos
{
    public class ProdutosController : Controller
    {
        // GET: ProdutosController

        // Passo 2 - Criar a ação
        // Uma view depende de uma ação e vice-versa
        public ActionResult Index()
        {
            // passo 4 - objeto
            //criar um objeto com varios produtos, por isso usamos list
            List<Produto> produtos = new List<Produto>
            {
                new Produto(1, "Mouse Game", 129.9m, 10),
                new Produto(1, "Teclado Mecanico", 249.9m, 5),
                new Produto(1, "Monitor 24 Polegadas", 899.9m, 8),
                new Produto(1, "Headset Gamer", 179.9m, 15),
            };
            return View();
        }
    }
}
