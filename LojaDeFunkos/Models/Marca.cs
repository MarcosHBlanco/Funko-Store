using System;
namespace LojaDeFunkos.Models;

public class Marca
{
    public int MarcaId { get; set; }
    public string Descricao { get; set; }

    public ICollection<Funko>? Funkos { get; set; }
}

