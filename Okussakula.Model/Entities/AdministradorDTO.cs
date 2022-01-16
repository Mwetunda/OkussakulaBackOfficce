using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class AdministradorListGeralDTO
    {
        public long AdministratorId { get; set; }
        public int InstituitionId { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
        public bool IsDelect { get; set; }
        public bool State { get; set; }

        public InstituitionListAnyDTO Instituition { get; set; }
    }
    public class AdministradorPerfilDTO
    {
        public long AdministratorId { get; set; }
        public int InstituitionId { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public InstituitionListAnyDTO Instituition { get; set; }
    }
    public class AdministradorListDTO
    {
        public long AdministratorId { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
    public class AdministradorCreatDTO
    {
        public int InstituitionId { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
    public class AdministradorLoginDTO
    {
        public string Senha { get; set; }
        public string Telephone { get; set; }
    }
}
