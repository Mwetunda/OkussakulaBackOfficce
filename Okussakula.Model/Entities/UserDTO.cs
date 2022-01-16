using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Model.DTO
{
    public class UserDTO
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public string BI { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Photo { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
        public bool State { get; set; }
    }
    public class UserPerfilDTO
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public string BI { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
    public class UserCreatDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Senha { get; set; }
    }
    public class UserFinishDTO
    {
        public string BI { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
    public class UserUpdateDTO
    {
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public string BI { get; set; }
        public string Email { get; set; }
    }
    public class UserUpdateFotoDTO
    {
        public string Foto { get; set; }
    }
    public class UserLoginDTO
    {
        public string Senha { get; set; }
        public string Telephone { get; set; }
    }
    public class UserAuxiliarListlDTO
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
    }
}
