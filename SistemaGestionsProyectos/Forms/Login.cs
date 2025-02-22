using SistemaGestionsProyectos.ClasesDao;
using SistemaGestionsProyectos.DAO;
using SistemaGestionsProyectos;
using SistemaGestionsProyectos.Forms;
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


        public Login()
        {
            InitializeComponent();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContra.Text.Trim();


            try
            {
                Conexion conexion = Conexion.getInstancia();

                UsuarioDao2 usuarioDao = new UsuarioDao2(conexion);

                Usuario usuarios = usuarioDao.ValidarCredenciales(usuario, contraseña);

                if (usuarios != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso. Bienvenido " + usuarios.Correo);

                    PanelAdmin panelAdmin = new PanelAdmin(usuarios.Correo); 
                    panelAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos.");
                    txtContra.Text = ""; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
