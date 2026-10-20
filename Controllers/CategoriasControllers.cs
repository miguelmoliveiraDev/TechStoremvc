using Microsoft.AspNetCore.Mvc;
using TechStoremvc.Models;

namespace TechStoremvc.Controllers // o ":" significa herança
// Herança  = herda as caracteristicas de um controler. :)
// Conceitos de POO -> Programação Orientada a Objetos
{
    public class CategoriasController : Controller
    {
        // GET: ProdutosController

        // Passo 2 - Criar a ação
        // Uma view depende de uma ação e vice-versa
        public ActionResult Index()
        {
            // passo 4 - objeto
            //criar um objeto com varios produtos, por isso usamos list
            List<Categoria> Categorias = new List<Categoria>
            {
                new Categoria(1, "Informática", "Computadores e componentes", true),
                new Categoria(2, "Perifericos", "Mouse, teclado e acessórios", true),
                new Categoria(3, "Áudio", "Fones, caixas e microfones", true),
                new Categoria(4, "Monitores", "Telas e monitores", true),
                new Categoria(5, "Descontinuados", "Categorias fora de uso", false),
            };
            return View(Categorias);
        }
    }                           
}
