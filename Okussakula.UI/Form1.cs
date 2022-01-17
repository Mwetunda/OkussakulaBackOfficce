using Okussakula.Model.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okussakula.UI
{
    public partial class Form1 : Form
    {
        private readonly ISpeciality _speciality;

        public Form1(ISpeciality speciality)
        {
            _speciality = speciality;

            InitializeComponent();

            GetAll();
        }

        private void GetAll()
        {
            var result = _speciality.List();

            if(result.Result.Exito)
            {

            }
            else
            {

            }
        }
    }
}
