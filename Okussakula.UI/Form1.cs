using Okussakula.Service.Services;
using Okussakula.UI.User;
using System;
using System.Windows.Forms;

namespace Okussakula.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.Show();
            this.Hide();
        }
    }
}
