using Okussakula.Model.DTO;
using Okussakula.Model.Interface;
using System;
using System.Windows.Forms;

namespace Okussakula.UI.User
{
    public partial class FormLogin : Form
    {
        private readonly ISpeciality _speciality;

        AdministradorLoginDTO administradorLoginDTO;

        public FormLogin(ISpeciality speciality)
        {
            _speciality = speciality;

            //administradorLoginDTO = new AdministradorLoginDTO();
            
            InitializeComponent();

            
        }

        private void GetAll()
        {

            var result = _speciality.List();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}
