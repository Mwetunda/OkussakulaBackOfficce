using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;
using System.Linq;

namespace Okussakula.Service.Services
{
    public class ConsultServices : IConsult
    {
       
        public ConsultServices()
        {

        }

        
        public Response Insert(ConsultCreatDTO entity)
        {
            var resposta = new Response();

            try
            {
                
               
                return resposta.Good("Consulta marcada com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao marcar consulta "+e);
            }
        }

        public Response List(long instituitionId)
        {
            var resposta = new Response();

            try
            {
               
                return resposta.Good("Lista de Consultas");
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
               

                return resposta.Good("Lista de Consultas");
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListByUser(long userId)
        {
            var resposta = new Response();

            try
            {
                
                return resposta.Good("Lista de Consultas");
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }
    }
}
