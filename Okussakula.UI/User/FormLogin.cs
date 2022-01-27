using Newtonsoft.Json;
using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okussakula.UI.User
{
    public partial class FormLogin : Form
    {
        //private readonly ISpeciality _speciality;

        AdministradorLoginDTO administradorLoginDTO;

        public FormLogin()
        {
            //_speciality = speciality;

            administradorLoginDTO = new AdministradorLoginDTO();
            
            InitializeComponent();

            
        }

        public async Task<Response> GetAll()
        {
            var response = new Response();

            try
            {

                var uri = "http://173.249.48.24:8027/api/Speciality/Listar";


                using (var cliente = new HttpClient())
                {
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
                        return response.Bad(get.StatusCode + " " + result.Mensagem);
                    }
                }
            }
            catch (Exception e)
            {
                return response.Bad("Erro ao gerar lista " + e);
            }
        }

        public async Task<Response> Logar()
        {
            var response = new Response();

            try
            {
                var uri = "http://173.249.48.24:8027/api/Administrador/Login";

                administradorLoginDTO.Telephone = TxtPhone.Text;
                administradorLoginDTO.Senha = TxtPassword.Text;

                using (var cliente = new HttpClient())
                {

                    var administrador = JsonConvert.SerializeObject(administradorLoginDTO);

                    var content = new StringContent(administrador, Encoding.UTF8, "application/json");

                    var result = await cliente.PostAsync(uri, content);


                    var resposta = new Response();

                    var ProdutoJsonString = result.Content.ReadAsStringAsync();

                    resposta = JsonConvert.DeserializeObject<Response>(ProdutoJsonString.Result);


                    if (result.IsSuccessStatusCode)
                    {
                        
                        return response.Good(""+ resposta.Mensagem, resposta.Objeto);
                    }
                    else
                    {
                        return response.Bad(result.StatusCode +" "+resposta.Mensagem);
                    }
                }
            }
            catch (Exception e)
            {
                return response.Bad("Erro ao gerar lista " + e);
            }
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            _ = Logar();
        }
    }
}
