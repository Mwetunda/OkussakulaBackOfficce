using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Service.Services
{
    public class AdministradorServices: IAdministrador
    {
        
        public AdministradorServices()
        {
            
        }

        //public Task<Response> Insert([FromBody] AdministradorCreatDTO dto)
        //{
        //    return _administrador.Insert(dto);
        //}

        //public Task<Response> Profile()
        //{
        //    return _administrador.Profile();
        //}

        public async Task<Response> Login(AdministradorLoginDTO administradorDTO)
        {
            var response = new Response();

            try
            {
                var uri = "http://173.249.48.24:8027/api/Administrador/Login";

                using (var cliente = new HttpClient())
                {

                    var administrador = JsonConvert.SerializeObject(administradorDTO);

                    var content = new StringContent(administrador, Encoding.UTF8, "application/json");

                    var result = await cliente.PostAsync(uri, content);


                    var resposta = new Response();

                    var ProdutoJsonString = result.Content.ReadAsStringAsync();

                    resposta = JsonConvert.DeserializeObject<Response>(ProdutoJsonString.Result);


                    if (result.IsSuccessStatusCode)
                    {

                        return response.Good("" + resposta.Mensagem, resposta.Objeto);
                    }
                    else
                    {
                        return response.Bad(result.StatusCode + " " + resposta.Mensagem);
                    }
                }
            }
            catch (Exception e)
            {
                return response.Bad("Erro ao gerar lista " + e);
            }
        }
    }
}
