using Microsoft.AspNetCore.Mvc;
using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System.Threading.Tasks;

namespace Okussakula.Service.Services
{
    public class SpecialityServices
    {
        private readonly ISpeciality _speciality;
        public SpecialityServices(ISpeciality speciality)
        {
            _speciality = speciality;
        }

        public Task<Response> List()
        {
            return _speciality.List();
        }

        public Task<Response> Insert([FromBody] SpecialityCreatDTO dto)
        {
            return _speciality.Insert(dto);
        }
    }
}
