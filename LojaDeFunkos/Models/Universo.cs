using System;
namespace LojaDeFunkos.Models;

public class Universo
{
	public int UniversoId { get; set; }
	public string Nome { get; set; }

	public ICollection<Funko>? funkos { get; set; }
}

