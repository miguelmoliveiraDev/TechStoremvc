using System;

namespace TechStoremvc.Models;

public class Produto
{
    // Passo 01 - Criar Models
    // Atrbutos
    public int Id { get; set; }  // GET Para obter um id = identificador
                                 // SET para definir um nove valor, atualizar, etc
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }

    //Metodo construtor -  Define valores iniciais desses atributos acima
    public Produto(
            int id,
            string nome,
            decimal preco,
            int estoque
    )
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}

