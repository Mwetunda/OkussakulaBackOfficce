using Okussakula.Model.DTO;

namespace Okussakula.Model.Interface
{
    public interface IExam
    {
        Response Insert(ExamCreatDTO dto);
        
    }
}
