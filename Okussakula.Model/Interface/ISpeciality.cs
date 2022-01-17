using Okussakula.Model;
using Okussakula.Model.DTO;
using System.Threading.Tasks;

namespace Okussakula.Model.Interface
{
    public interface ISpeciality
    {
        Task<Response> List();
    }
}
