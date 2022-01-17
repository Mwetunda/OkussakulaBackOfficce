using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;

namespace Okussakula.Service.Services
{
    public class ExamMedicServices : IExamMedic
    {
       
        public ExamMedicServices()
        {

        }

        public Response Insert(ExamMedicCreatDTO entity)
        {
            var resposta = new Response();

            try
            {
            
                return resposta.Good("Administrador registado com sucesso", entity);
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao registar administrador "+e);
            }
        }
    }
}
