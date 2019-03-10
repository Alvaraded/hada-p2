using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    public class TemperaturaMaximaExcedidaArgs
    {
        public int temperatura
        {
            set;
            get;
        }
        public TemperaturaMaximaExcedidaArgs(int t)
        {
            this.temperatura = t;
        }
    }
}
