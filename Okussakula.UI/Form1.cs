using Okussakula.Model.Interface;
using Okussakula.Service.Services;
using Okussakula.UI.User;
using System;
using System.Windows.Forms;

namespace Okussakula.UI
{
    public partial class Form1 : Form
    {
        private readonly IAdministrador _administrador;
        public Form1(IAdministrador administrador)
        {
            _administrador = administrador;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin(_administrador);
            Login.Show();
            this.Hide();
        }
    }
}
