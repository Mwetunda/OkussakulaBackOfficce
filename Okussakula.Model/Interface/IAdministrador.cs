using Okussakula.Model.DTO;
using Refit;
using System.Threading.Tasks;

namespace Okussakula.Model.Interface
{
    public interface IAdministrador
    {

        [Post("/Administrador/Registar")]
        Task<Response> Insert(AdministradorCreatDTO administrador);

        [Get("/Administrador/Perfil")]
        Task<Response> Profile();

        [Post("/Administrador/Login")]
        Task<Response> Login(AdministradorLoginDTO administrador);

    }
}
