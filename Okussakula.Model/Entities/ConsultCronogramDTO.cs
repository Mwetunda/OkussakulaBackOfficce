using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class ConsultCronogramDTO
    {
        public long CronogramConsultId { get; set; }
        public DateTime Data { get; set; }
        public double Preco { get; set; }
        [Required]
        public string Observacao { get; set; }

        public ICollection<ConsultHorarioListDTO> ConsultHorarios { get; set; }
        public InstituitionSpecialityDTO InstituitionSpeciality { get; set; }
    }
    public class ConsultCronogramConsultDTO
    {
        public DateTime Data { get; set; }

        public InstituitionSpecialityConsultDTO InstituitionSpeciality { get; set; }
    }
    public class ConsultCronogramCreatDTO
    {
        [Required]
        public long InstituitionSpecialityId { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public string Observacao { get; set; }
        [Required]
        public string Intervalo { get; set; }
    }
}
