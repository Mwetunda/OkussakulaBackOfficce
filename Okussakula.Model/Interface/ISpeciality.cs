using Okussakula.Model;
using Okussakula.Model.Data;

namespace Okussakula.Service.Interface
{
    public interface ISpeciality
    {
        Response Insert(Speciality dto);
        Response List();
        //Response List(int page, int take, string filtro = null);
        //Response GetByID(Guid id);
        //Response Update(FuncionarioDTOApiUpdate dto);
        //Response Delete(Guid id);
        //Response RecoveryPassword(string chave, string newPassword);
        //Response RequestRecoveryPassword(string email);
        //Response UpdatePassword(Guid id, string actualPassword, string newPassword);
        //Response ReactivarAdm(Guid id);
    }
}
