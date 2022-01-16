using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class SpecialityDTO
    {
        public long SpecialityId { get; set; }
        public string Designation { get; set; }
        public bool State { get; set; }
    }
    public class SpecialityCreatDTO
    {
        public string Designation { get; set; }
    }
}
