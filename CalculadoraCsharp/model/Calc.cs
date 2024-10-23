using CalculadoraCsharp.model.operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp.Model
{
    public class Calc : ICalc
    {
        public int calculation(Ioperation operacao, int valor1, int valor2) 
        {
            return operacao.calc(valor1,valor2) ;
        }
    }
}
