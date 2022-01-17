using Okussakula.Model;
using Okussakula.Model.DTO;

namespace Okussakula.Model.Interface
{
    public interface IExamMedic
    {
        Response Insert(ExamMedicCreatDTO dto);
        
    }
}
