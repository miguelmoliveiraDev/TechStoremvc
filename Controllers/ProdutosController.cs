using Microsoft.AspNetCore.Mvc;
using TechStoremvc.Models;

namespace TechStoremvc.Controllers // o ":" significa herança
// Herança  = herda as caracteristicas de um controler. :)
// Conceitos de POO -> Programação Orientada a Objetos
{    public class ProdutosController : Controller
    {
        private readonly ProdutosDB _produtosDB;

        public ProdutosController()
        {
            _produtosDB = new ProdutosDB();
        }
        // GET: ProdutosController

        // Passo 2 - Criar a ação
        // Uma view depende de uma ação e vice-versa
        public ActionResult Index()
        {
            // passo 4 - objeto
            //criar um objeto com varios produtos, por isso usamos list
            List<Produto> produtos = _produtosDB.Listar();
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Produto? produto = _produtosDB.buscarPorId(id);
            if (produto is null)
                return NotFound();

                return View(produto);
        }

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produto produto)
        {
            if(!ModelState.IsValid)
                return View(produto);
            _produtosDB.Adicionar(produto);
            TempData["Sucesso"] = 
            "Produto cadastrado com sucesso!";
        return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Produto? produto = _produtosDB.buscarPorId(id);
            if (produto is null)
                return NotFound();

                return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Produto produto, int id)
        {
            if (id != produto.Id)
                return BadRequest();

            if(!ModelState.IsValid)
                return View(produto);

            bool atualizou =_produtosDB.Atualizar(produto);
            if(!atualizou)
                return NotFound();

            TempData["Sucesso"] = 
            "Produto atualizado com sucesso!";
        return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Produto? produto = _produtosDB.buscarPorId(id);
             if (produto is null)
                return NotFound();
            return View(produto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed( int id)
        {
            bool excluiu = _produtosDB.Excluir(id);    
            if(!excluiu)
                return NotFound();
                    
            TempData["Sucesso"] = 
                "Produto excluído com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    } 
} 