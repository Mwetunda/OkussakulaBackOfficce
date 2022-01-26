using Microsoft.AspNetCore.Mvc;
using Okussakula.Model;
using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using Okussakula.Service.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okussakula.UI.User
{
    public partial class FormLogin : Form
    {
        private readonly IAdministrador _administrador;
        AdministradorLoginDTO administradorLoginDTO;
        AdministradorServices administradorServices;

        public FormLogin(IAdministrador administrador)
        {
            _administrador = administrador;

            administradorLoginDTO = new AdministradorLoginDTO();
            administradorServices = new AdministradorServices();
            
            InitializeComponent();
        }

        private void Logar()
        {

            administradorLoginDTO.Senha = TxtPassword.Text;
            administradorLoginDTO.Telephone = TxtPhone.Text;

            var result = administradorServices.Login(administradorLoginDTO, _administrador);
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            Logar();
        }
    }
}
