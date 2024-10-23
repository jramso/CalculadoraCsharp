using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp.dto
{
    public class ResponseDto
    {
        public int result { get; set; } = 0;
        public ResponseDto(int result) { this.result = result; }

    }
}
