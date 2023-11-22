using System.ComponentModel.DataAnnotations;

namespace LojaDeFunkos.Models;

public class Funko
{
    public int FunkoId { get; set; }
    public string Nome { get; set; }

    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Display(Name = "Caminho URl da imagem")]
    public string ImagemUri { get; set; }


    [Display(Name ="Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }

    [Display(Name = "Entrega Expressa")]
    public bool EntregaExpressa { get; set; }
    public string EntregaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";

    [Display(Name = "Dispoível em")]
    [DisplayFormat(DataFormatString ="{0:MMMM \\de yyyy}")]
    public DateTime DataCadastro { get; set; }
}

