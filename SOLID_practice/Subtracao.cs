using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_practice
{
    class Subtracao : IOperacao
    {
        public double resultado { get; set; }
        public double op(double x, double y)
        {
            this.resultado = x - y;
            return x - y;
        }
    }
}
