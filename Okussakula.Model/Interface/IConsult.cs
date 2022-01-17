﻿using Okussakula.Model.DTO;

namespace Okussakula.Model.Interface
{
    public interface IConsult
    {
        Response Insert(ConsultDTO dto);
        Response List(long instituitionId);
        Response ListBySpeciality(long instituitionId, long specialityId);
        Response ListByUser(long userId);
       
    }
}
