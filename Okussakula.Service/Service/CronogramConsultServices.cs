using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;

namespace Okussakula.Service.Services
{
    public class CronogramConsultServices : ICronogramConsult
    {
       
        public CronogramConsultServices()
        {

        }

        public Response Insert(ConsultCronogramCreatDTO entity, string intevalo)
        {
            var resposta = new Response();

            try
            {

                return resposta.Good("Cronograma criado com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao criar cronograma "+e);
            }
        }

        
        
        public Response List(long instituitionId)
        {
            var resposta = new Response();

            try
            {
               

                return resposta.Good("Lista de Cronogramas");
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListBySpeciality(long instituitionId, long specialityId)
        {
            var resposta = new Response();

            try
            {
               
                return resposta.Good("Lista de Cronogramas");
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListBySpecialityAndData(long instituitionId, long specialityId, DateTime date)
        {
            var resposta = new Response();

            try
            {
                
                return resposta.Good("Lista de Cronogramas");
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }
    }
}
