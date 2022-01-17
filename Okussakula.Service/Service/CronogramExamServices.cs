using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;

namespace Okussakula.Service.Services
{
    public class CronogramExamServices : ICronogramExam
    {

        public CronogramExamServices()
        {
            
        }


        public Response Insert(CronogramExamCreatDTO entity, string intevalo)
        {
            var resposta = new Response();

            try
            {

                return resposta.Good("Cronograma criado com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao criar cronograma " + e);
            }
        }
    }
}
