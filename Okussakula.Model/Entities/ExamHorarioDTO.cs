using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class ExamHorarioDTO
    {
        public long ExamHorarioId { get; set; }
        public long CronogramExamId { get; set; }
        public int Hora { get; set; }

        public bool State { get; set; }

        public CronogramExamDTO CronogramExam { get; set; }
    }
    public class ExamHorarioListDTO
    {
        public long ExamHorarioId { get; set; }
        public int Hora { get; set; }
    }
    public class ExamHorarioCreatDTO
    {
        [Required]
        public long CronogramExamId { get; set; }
        [Required]
        public int Hora { get; set; }
    }
}
