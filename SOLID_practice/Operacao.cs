using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_practice
{
    interface IOperacao
    {
        double resultado { get; set; }
        double op(double x, double y);
    }
}
