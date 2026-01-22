using System.ComponentModel.DataAnnotations;

namespace LojaDeFunkos.Models;

public class Funko
{ 
    public int FunkoId { get; set; }

    [StringLength(50, MinimumLength = 10, ErrorMessage = "Este campo deve conter entre 10 e 50 caracteres.")]
    public required string Nome { get; set; } = string.Empty;
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

   
    [StringLength(100, MinimumLength = 50, ErrorMessage = "Este campo deve conter entre 50 e 100 caracteres.")]
    [Display(Name = "Descrição")]
    public required string Descricao { get; set; }

    [Display(Name = "Caminho URl da imagem")]
    public required string ImagemUri { get; set; } = string.Empty;

    [Display(Name ="Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }

    [Display(Name = "Status")]
    public bool Status { get; set; }
    public string EntregaExpressaFormatada => Status ? "Herói" : "Vilão";

    [Display(Name = "Personagem criado em")]
    [DisplayFormat(DataFormatString ="{0:MMMM \\de yyyy}")]

    [DataType("month")]
    public DateTime DataCadastro { get; set; }

    [Display(Name = "Marca")]
    public int? MarcaId { get; set; }

    [Display(Name = "Universo")]
    public ICollection<Universo>? Universos { get; set; }
}

