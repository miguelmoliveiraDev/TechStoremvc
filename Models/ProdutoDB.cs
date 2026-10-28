namespace TechStoremvc.Models;

    public class ProdutosDB
{
        // Metodo que vai listar novos objetos de um produto
        // e armazena-los na variavel produtos
        private static readonly List<Produto> produtos = new()
        {
            new Produto(1, "Mouse Game", 129.9m, 10),
            new Produto(1, "Teclado Mecanico", 249.9m, 5),
            new Produto(1, "Monitor 24 Polegadas", 899.9m, 8),
            new Produto(1, "Headset Gamer", 179.9m, 15),
        };

        // Passo 02 - Criar os metodos do CRUD e remover toda regra de negocio do controll
        // Responsabilidade do listar: Devolver/mostrar os produtos. Igual ao index
        // Controiller
        public List<Produto> Listar()
    {
        return produtos;
    }

    public Produto? buscarPorId(int id)
    {
        return produtos.FirstOrDefault(
            produto => produto.Id == id
        );
    }
    public void Adicionar(Produto produto)
    {
        produto.Id = produtos.Count + 1;
        produtos.Add(produto);
    }
    public bool Atualizar(Produto produtoAtualizado)
    {
        Produto? produtoExistente =
            buscarPorId(produtoAtualizado.Id);
        
        if(produtoExistente is null)
            return false;
        
        produtoExistente.Nome = produtoAtualizado.Nome;
        produtoExistente.Preco = produtoAtualizado.Preco;
        produtoExistente.Estoque = produtoAtualizado.Estoque;
        return true;
    }

    public bool Excluir(int id)
    {
        Produto? produto = buscarPorId(id);
        if(produto is null)
            return false;
        produtos.Remove(produto);

        return true;
    }
}
