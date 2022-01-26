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
    public partial class FormMenu : Form
    {
        public static string token;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
