using CalculadoraCsharp.model.operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp.Model
{
    internal interface ICalc
    {
        public int calculation(Ioperation operacao,int value1, int value2);
    }
}
