using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermap.Domain.Entities
{
    internal class Empresa : Usuario
    {
        public string CNPJ { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public Responsavel FuncionarioResponsavel { get; set; }
    }
}
