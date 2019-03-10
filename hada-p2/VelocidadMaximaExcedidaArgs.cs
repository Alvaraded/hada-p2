using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    public class VelocidadMaximaExcedidaArgs
    {
        public int velocidad
        {
            set;
            get;
        }
        public VelocidadMaximaExcedidaArgs(int v)
        {
            this.velocidad = v;
        }
    }
}
