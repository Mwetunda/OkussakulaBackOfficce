using Okussakula.Model;
using Okussakula.Model.DTO;
using System;

namespace Okussakula.Model.Interface
{
    public interface ICronogramConsult
    {
        Response Insert(ConsultCronogramCreatDTO dto, string intevalo);

        Response List(long instituitionId);
        Response ListBySpeciality(long instituitionId, long specialityId);
        Response ListBySpecialityAndData(long instituitionId, long specialityId, DateTime date);
    }
}
