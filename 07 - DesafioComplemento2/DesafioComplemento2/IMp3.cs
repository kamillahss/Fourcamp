using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioComplemento2
{
    public interface IMp3 : IPlayer
    {

        public abstract void Next();

        public abstract void Previous();
    }
}
