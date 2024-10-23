using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculadoraCsharp.dto;
using CalculadoraCsharp.model.operation;
using CalculadoraCsharp.Model;

namespace CalculadoraCsharp.Controller
{
    public class ControllerCalc
    {
        public ResponseDto Calc(RequestDto requestDTO)
        {
            int result = 0;
            ICalc calc = null;

            Ioperation operation = null;
            switch (requestDTO.opcao)
            {
                case 1:
                    operation = new Soma();
                    break;
                case 2:
                    operation = new Subtrair();
                    break;
                case 3:
                    operation = new Multiplicar();
                    break;
                case 4:
                    operation = new Dividir();
                    break;

                default:
                    throw new ArgumentException("Opção de operação inválida: " + requestDTO.opcao);
            }

            calc = new Calc();
            result = calc.calculation(operation, requestDTO.valor1, requestDTO.valor2);
            return new ResponseDto(result);
        }
    }
}

