using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class ConsultDTO
    {
        public long ConsultId { get; set; }
        public long UserId { get; set; }
        public long ConsultHorarioId { get; set; }
        public DateTime DataInsert { get; set; }
        public DateTime DataUpdate { get; set; }

        [MaxLength(150)]
        public string Descricao { get; set; }

        public bool State { get; set; }

        public UserDTO User { get; set; }
        public ConsultHorarioDTO ConsultHorario { get; set; }
    }
    public class ConsultListDTO
    {
        public long ConsultId { get; set; }
        public DateTime DataInsert { get; set; }
        public string Descricao { get; set; }
        public bool State { get; set; }

        public ConsultHorarioListDTO ConsultHorario { get; set; }
        public UserAuxiliarListlDTO User { get; set; }
        
    }
    public class ConsultListConsultsDTO
    {
        public long ConsultId { get; set; }
        public DateTime DataInsert { get; set; }
        public string Descricao { get; set; }
        public bool State { get; set; }

        public ConsultHorarioListConsultDTO ConsultHorario { get; set; }
        public UserAuxiliarListlDTO User { get; set; }

    }
    public class ConsultCreatDTO
    {
        public long UserId { get; set; }
        public long ConsultHorarioId { get; set; }

        [MaxLength(150)]
        public string Descricao { get; set; }
    }
}

