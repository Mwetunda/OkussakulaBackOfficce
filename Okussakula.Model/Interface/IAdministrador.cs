using Okussakula.Model.DTO;

namespace Okussakula.Model.Interface
{
    public interface IAdministrador
    {
        Response Insert(AdministradorCreatDTO entity);
        Response GetByID(long id);
        Response Login(AdministradorLoginDTO entity, string secret);
        
    }
}
