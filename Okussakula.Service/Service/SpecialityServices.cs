using Newtonsoft.Json;
using Okussakula.Model;
using Okussakula.Model.Interface;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Okussakula.Service.Services
{
    public class SpecialityServices:ISpeciality
    {
        public async Task<Response> List()
        {
            var response = new Response();

            try
            {

                var uri = "http://173.249.48.24:8027/api/Speciality/Listar";

                var cliente = new HttpClient();

                var get = await cliente.GetAsync(uri);

                var result = new Response();

                if (get.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await get.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<Response>(ProdutoJsonString);

                    return response.Good("" + result.Mensagem, result.Objeto);

                }
                else
                {
                    return response.Bad(get.StatusCode+" "+ result.Mensagem);
                }
            }
            catch (Exception e)
            {
                return response.Bad("Erro ao gerar lista " + e);
            }
        }
    }
}
