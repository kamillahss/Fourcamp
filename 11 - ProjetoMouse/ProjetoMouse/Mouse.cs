using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMouse
{
    internal class Mouse
    {
        public int Id { get; set; }

        public ICollection<Defeito> Defeitos { get; set; }

        public Mouse(int id, List<Defeito> defeitos)
        {
            Id = id;
            Defeitos = defeitos;
        }
    }
}
