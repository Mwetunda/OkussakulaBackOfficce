using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class CronogramExamDTO
    {
        public long CronogramExamId { get; set; }
        public long InstituitionExamId { get; set; }
        public DateTime Data { get; set; }
        public double Preco { get; set; }
        public string Observacao { get; set; }

        public InstituitionExamDTO InstituitionExam { get; set; }
    }
    public class CronogramExamCreatDTO
    {
        [Required]
        public long InstituitionExamId { get; set; }
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
