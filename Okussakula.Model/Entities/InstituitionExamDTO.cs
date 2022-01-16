using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class InstituitionExamDTO
    {
        public long InstituitionExamId { get; set; }

        //public bool State { get; set; }
        public string Preco { get; set; }

        //public InstituitionListAnyDTO Instituition { get; set; }
        public ExamDTO Exam { get; set; }
    }
    public class InstituitionExamCreatDTO
    {
        [Required]
        public long InstituitionId { get; set; }
        [Required]
        public long ExamId { get; set; }
        public string Preco { get; set; }
    }
}
