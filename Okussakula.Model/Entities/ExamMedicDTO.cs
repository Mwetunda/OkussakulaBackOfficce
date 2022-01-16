using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class ExamMedicDTO
    {
        public long ExamMedicId { get; set; }

        public DateTime DataInsert { get; set; }
        public DateTime DataUpdate { get; set; }

        [MaxLength(150)]
        public string Descricao { get; set; }

        public bool State { get; set; }

        public ExamHorarioListDTO ExamHorario { get; set; }
        public UserAuxiliarListlDTO User { get; set; }
    }
    public class ExamMedicCreatDTO
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public long ExamHorarioId { get; set; }

        [MaxLength(150)]
        public string Descricao { get; set; }
    }
}
