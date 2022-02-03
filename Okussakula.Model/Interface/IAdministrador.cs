using Okussakula.Model.DTO;
using System.Threading.Tasks;

namespace Okussakula.Model.Interface
{
    public interface IAdministrador
    {


        //Task<Response> Insert(AdministradorCreatDTO administrador);


        //Task<Response> Profile();


        Task<Response> Login(AdministradorLoginDTO administrador);

    }
}
