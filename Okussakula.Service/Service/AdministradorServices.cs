using Microsoft.AspNetCore.Mvc;
using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Okussakula.Service.Services
{
    public class AdministradorServices
    {
        public AdministradorServices()
        {
            //_administrador.GetType();
        }

        //public Task<Response> Insert([FromBody] AdministradorCreatDTO dto)
        //{
        //    return _administrador.Insert(dto);
        //}

        //public Task<Response> Profile()
        //{
        //    return _administrador.Profile();
        //}

        public Task<Response> Login(AdministradorLoginDTO dto, IAdministrador administrador)
        {
            return administrador.Login(dto);
        }
    }
}
