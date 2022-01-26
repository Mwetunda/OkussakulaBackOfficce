using Okussakula.Model;
using Okussakula.Model.DTO;
using Refit;
using System.Threading.Tasks;

namespace Okussakula.Model.Interface
{
    public interface ISpeciality
    {
        [Get("/Speciality/Listar")]
        Task<Response> List();

        [Post("/Speciality/Registar")]
        Task<Response> Insert(SpecialityCreatDTO speciality);
    }
}
