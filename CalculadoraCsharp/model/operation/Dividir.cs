using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp.model.operation
{
    public class Dividir : Ioperation
    {
        public int calc(int value1, int value2)
        {
            if(value2==0) throw new DivideByZeroException("Não é possivel dividir por 0");
            return value1/value2;
        }
    }
}
