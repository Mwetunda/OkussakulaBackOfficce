using System.Threading.Tasks;

namespace Okussakula.Model.Interface
{
    public interface ISpeciality
    {
        Task<Response> List();
    }
}
