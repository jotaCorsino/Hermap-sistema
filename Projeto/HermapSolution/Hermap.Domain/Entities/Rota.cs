using Hermap.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermap.Domain.Entities
{
    internal class Rota
    {
        public int Id { get; set; }
        public Motorista NomeMotorista { get; set; }
        public Veiculo TipoVeiculo { get; set; }
        public double Mensalidade { get; set; }
        public int VagasDisponiveis { get; set; }
        public string Destino { get; set; }
        public DateTime HorarioChegada { get; set; }
        public List<Endereco> PontoDeEmbarque { get; set; }
    }
}
