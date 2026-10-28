namespace TechStoremvc.Models;

public class CategoriasDB
{
    private static List<Categoria> _categorias = new List<Categoria>
    {
        new Categoria(1, "Informática", "Computadores e componentes", true),
        new Categoria(2, "Perifericos", "Mouse, teclado e acessórios", true),
        new Categoria(3, "Áudio", "Fones, caixas e microfones", true),
        new Categoria(4, "Monitores", "Telas e monitores", true),
        new Categoria(5, "Descontinuados", "Categorias fora de uso", false),
    };

    public List<Categoria> Listar()
    {
        return _categorias;
    }

    public Categoria? buscarPorId(int id)
    {
        return _categorias.FirstOrDefault(c => c.Id == id);
    }

    public void Adicionar(Categoria categoria)
    {
        categoria.Id = _categorias.Any() ? _categorias.Max(c => c.Id) + 1 : 1;
        _categorias.Add(categoria);
    }

    public bool Atualizar(Categoria categoria)
    {
        var existente = buscarPorId(categoria.Id);
        if (existente == null) return false;

        existente.Nome = categoria.Nome;
        existente.Descricao = categoria.Descricao;
            
        return true;
    }

    public bool Excluir(int id)
    {
        var existente = buscarPorId(id);
        if (existente == null) return false;

        _categorias.Remove(existente);
        return true;
    }
}
