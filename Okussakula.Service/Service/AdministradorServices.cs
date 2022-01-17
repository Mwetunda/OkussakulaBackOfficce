using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;
using System.Linq;

namespace Okussakula.Service.Service
{
    public class AdministradorServices:IAdministrador
    {
       
        public AdministradorServices()
        {

        }

        
        public Response Insert(AdministradorCreatDTO entity)
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

        public Response Login(AdministradorLoginDTO entity, string secret)
        {
            var res = new Response();

            try
            {
               

                return res.Good("Sucesso", entity);
            }
            catch (Exception e)
            {

                return res.Bad("Erro ao efectuar login "+e);
            }
        }

        public Response GetByID(long id)
        {
            var res = new Response();

            try
            {
                
                return res.Bad("Erro ao pesquizar administrador");
            }
            catch (Exception e)
            {
                
                return res.Bad("Erro ao pesquizar administrador " + e);
            }
        }
    }
}
