using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class ConsultHorarioDTO
    {
        public long ConsultHorarioId { get; set; }
        public long CronogramConsultId { get; set; }
        [Required]
        public int Hora { get; set; }

        public bool State { get; set; }

        public ConsultCronogramDTO ConsultCronogram { get; set; }
    }
    public class ConsultHorarioListDTO
    {
        public long ConsultHorarioId { get; set; }
        public int Hora { get; set; }
    }
    public class ConsultHorarioListConsultDTO
    {
        public int Hora { get; set; }
        public ConsultCronogramConsultDTO CronogramConsult { get; set; }
    }
    public class ConsulHorarioCreatDTO
    {
        [Required]
        public long CronogramConsultId { get; set; }
        [Required]
        public int Hora { get; set; }
    }
}
