using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class ExamDTO
    {
        public long ExamId { get; set; }
        public string Designation { get; set; }
        public bool State { get; set; }
    }
    public class ExamCreatDTO
    {
        public string Designation { get; set; }
    }

}
