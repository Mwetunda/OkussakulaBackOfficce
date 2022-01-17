using Okussakula.Model;
using Okussakula.Model.DTO;

namespace Okussakula.Model.Interface
{
    public interface ICronogramExam
    {
        Response Insert(CronogramExamCreatDTO dto, string intervalo);

    }
}
