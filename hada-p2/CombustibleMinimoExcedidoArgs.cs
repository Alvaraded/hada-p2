using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    public class CombustibleMinimoExcedidoArgs
    {
        public int combustible
        {
            set;
            get;
        }

        public CombustibleMinimoExcedidoArgs(int c)
        {
            this.combustible = c;
        }
    }
}
