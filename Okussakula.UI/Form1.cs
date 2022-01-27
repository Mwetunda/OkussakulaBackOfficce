using Okussakula.Model.Interface;
using Okussakula.UI.User;
using System;
using System.Windows.Forms;

namespace Okussakula.UI
{
    public partial class Form1 : Form
    {
        //private readonly ISpeciality _speciality;
        public Form1(ISpeciality speciality)
        {
           //_speciality = speciality;

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
