using System;
using System.ComponentModel.DataAnnotations;

namespace TechStoremvc.Models;

public class Categoria
{
 // Passo 01 - Criar Models
    // Atrbutos
    public int Id { get; set; }  // GET Para obter um id = identificador
                                 // SET para definir um nove valor, atualizar, etc
    [Required(ErrorMessage ="Informe um nome")]
    [StringLength(
        100,
        MinimumLength = 3,
        ErrorMessage = "O nome deve possuir entre 3 e 100 caracteres"
        )]
    public string Nome { get; set; }
    public string Descricao { get; set; }
    //Metodo construtor -  Define valores iniciais desses atributos acima

    public Categoria()
    {
        Nome = "";
        Descricao = "";
    }
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
    }
}
