using System;

namespace TechStoremvc.Models;

public class Categoria
{
 // Passo 01 - Criar Models
    // Atrbutos
    public int Id { get; set; }  // GET Para obter um id = identificador
                                 // SET para definir um nove valor, atualizar, etc
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool Ativa { get; set; }

    //Metodo construtor -  Define valores iniciais desses atributos acima
    public Categoria(
            int id,
            string nome,
            string descricao,
            bool ativa
    )
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Ativa = ativa;
    }
}
