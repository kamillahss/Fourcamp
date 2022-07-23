using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicicioHeranca
{
    public class Livro : Produto
    {
        private string Autor { get; set; }

        private string Titulo { get; set; }

        private string Isbn { get; set; }
    }
}
