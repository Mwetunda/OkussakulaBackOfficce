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
        private readonly IAdministrador _administrador;

        AdministradorLoginDTO administradorLoginDTO;

        public FormLogin(IAdministrador administrador)
        {
            _administrador = administrador;
            
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

        private void Logar()
        {
            administradorLoginDTO = new AdministradorLoginDTO();

            administradorLoginDTO.Telephone = TxtPhone.Text;
            administradorLoginDTO.Senha = TxtPassword.Text;

            var result = _administrador.Login(administradorLoginDTO);

            FormMenu Login = new FormMenu();
            Login.Show();
            this.Hide();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            Logar();
        }
    }
}
