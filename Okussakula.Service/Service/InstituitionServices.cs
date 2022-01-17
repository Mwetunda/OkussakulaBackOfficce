using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Okussakula.Service.Services
{
    public class InstituitionServices: IInstituition
    {
        
        public InstituitionServices()
        {

        }

        public Response Insert(InstituitionCreatDTO entity)
        {
            var resposta = new Response();

            try
            {
                return resposta.Good("Instituição registada com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao registar instituição " + e);
            }
        }
        public Response InsertSpeciality(List<InstituitionSpecialityCreatDTO> entity)
        {
            var resposta = new Response();

            try
            {
                return resposta.Good("Especialidades adicionadas com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao adicionar especialidades " + e);
            }
        }
        public Response InsertExam(List<InstituitionExamCreatDTO> entity)
        {
            var resposta = new Response();

            try
            {
                
                return resposta.Good("Exames adicionados com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao adicionar exames " + e);
            }
        }

        public Response List(long id)
        {
            var resposta = new Response();

            try
            {
               
                return resposta.Good("Lista de instituições");
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListSpeciality(long id)
        {
            var resposta = new Response();

            try
            {

                return resposta.Good("Lista de especialidades");
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListExam(long id)
        {
            var resposta = new Response();

            try
            {
               
                return resposta.Good("Lista de exames");
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }
    }
}
