using Okussakula.Model;
using Okussakula.Model.Interface;
using System;
using System.Linq;

namespace Okussakula.Service.Services
{
    public class SpecialityServices : ISpeciality
    {
       
        public SpecialityServices()
        {

        }

        public Response List()
        {
            var resposta = new Response();

            try
            {
               
                return resposta.Good("Lista de especialidades");
            }
            catch(Exception e)
            {
              return  resposta.Bad("Erro ao gerar lista " + e);
            }
        }
    }
}
