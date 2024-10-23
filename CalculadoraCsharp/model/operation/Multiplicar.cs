using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp.model.operation
{
    public class Multiplicar:Ioperation
    {
        public int calc(int value1,int value2)
        {
            return value1 * value2;
        }
    }
}
