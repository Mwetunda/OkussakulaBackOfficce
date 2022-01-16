using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class InstituitionSpecialityDTO
    {
        public long InstituitionSpecialityId { get; set; }
        public string Preco { get; set; }
        //public bool State { get; set; }

        //public InstituitionListAnyDTO Instituition { get; set; }
        public SpecialityDTO Speciality { get; set; }
    }
    public class InstituitionSpecialityConsultDTO
    {
        public SpecialityCreatDTO Speciality { get; set; }
    }
    public class InstituitionSpecialityCreatDTO
    {
        [Required]
        public long InstituitionId { get; set; }
        [Required]
        public long SpecialityId { get; set; }
        public string Preco { get; set; }
    }
    public class InstituitionSpecialityPrecoDTO
    {
        public string Preco { get; set; }
    }
}
