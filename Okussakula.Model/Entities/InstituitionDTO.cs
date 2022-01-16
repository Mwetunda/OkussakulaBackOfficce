using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class InstituitionListAllDTO
    {
        public long InstituitionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string NIF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        [Required]
        public string Photo { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
        public bool State { get; set; }

        public ICollection<AdministradorListDTO> Administrators { get; set; }
        public ICollection<InstituitionSpecialityDTO> InstituitionSpeciality { get; set; }
        public ICollection<InstituitionExamDTO> InstituitionExam { get; set; }
    }
    public class InstituitionListDTO
    {
        public long InstituitionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string NIF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        [Required]
        public string Photo { get; set; }
        public ICollection<InstituitionSpecialityPrecoDTO> InstituitionSpeciality { get; set; }
        //public ICollection<InstituitionExamDTO> InstituitionExam { get; set; }
    }
    public class InstituitionListAnyDTO
    {
        public long InstituitionId { get; set; }
        public string Name { get; set; }
    }
    public class InstituitionCreatDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string NIF { get; set; }
        [Required]
        public string Email { get; set; }
        public string Endereco { get; set; }
        [Required]
        public string Photo { get; set; }
    }
}
