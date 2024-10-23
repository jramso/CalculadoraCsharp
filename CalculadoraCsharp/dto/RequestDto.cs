using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp.dto
{
    public class RequestDto
    {
        public int opcao { get; set; }
        public int valor1 { get; set; }
        public int valor2 { get; set; }

        public RequestDto(int opcao,  int valor1, int valor2)
        {
            this.opcao = opcao;
            this.valor1 = valor1;
            this.valor2 = valor2;
        }


        
    }
}
