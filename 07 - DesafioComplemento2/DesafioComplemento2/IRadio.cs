﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioComplemento2
{
    public interface IRadio : IPlayer
    {
        public abstract void SelecionarEstacao(int prefixo);
    }
}
