using System.ComponentModel.DataAnnotations;

namespace Exemplo02.Models
{
    public class Veiculo
    {

        public int Id { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        [Display(Name = "Automático")]
        public bool Automatico { get; set; }

        public decimal Valor { get; set; }

        [Display(Name = "Data de fabricação"), DataType(DataType.Date)]
        public DateTime DataFabricacao { get; set; }

        public Cor Cor { get; set; }

    }

    public enum Cor
    {
        Branco, Preto, Vermelho, Azul, Prata
    }
}
