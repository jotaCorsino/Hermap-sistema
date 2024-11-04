using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermap.Domain.Entities
{
    internal class Motorista : Usuario
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public List<Veiculo> Veiculos { get; set; }
        public List<Rota> Rotas { get; set; }
    }
}
