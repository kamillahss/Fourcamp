using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
    public class Filme
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Duração")]
        public DateTime Duracao { get; set; }

        public string Sinopse { get; set; }

        [Display(Name = "Classificação")]
        public string Classificacao { get; set; }

        [Display(Name = "Gênero")]
        public Genero Genero { get; set; }
    }

    public enum Genero
    {
        Ação, Animação, Aventura, Comédia, Romance, Suspense, Terror
    }
}
