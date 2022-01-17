using Okussakula.Model.DTO;
using System.Collections.Generic;

namespace Okussakula.Model.Interface
{
    public interface IInstituition
    {
        Response Insert(InstituitionCreatDTO dto);

        Response InsertSpeciality(List<InstituitionSpecialityCreatDTO> dto);

        Response InsertExam(List<InstituitionExamCreatDTO> dto);
        Response List(long id);
        Response ListSpeciality(long id);
        Response ListExam(long id);

    }
}
