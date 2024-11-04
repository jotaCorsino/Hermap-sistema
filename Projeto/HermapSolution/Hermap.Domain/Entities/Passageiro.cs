using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermap.Domain.Entities
{
    internal class Passageiro : Usuario
    {
        public int Idade { get; set; }
        public string CPF { get; set; }
    }
}
