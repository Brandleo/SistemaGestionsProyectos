using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionsProyectos
{
    public partial class Login : Form
    {

        public string contrasenia;
        public string usuario;




        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            // Validar el usuario si es necesario y luego abrir el panel de administrador
            PanelAdmin adminPanel = new PanelAdmin(usuario);
            this.Hide();
            adminPanel.ShowDialog();

            this.Show();

            txtContra.Text = " ";
            txtUsuario.Text = " ";
        }
    }
}
