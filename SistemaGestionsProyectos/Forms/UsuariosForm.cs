using SistemaGestionsProyectos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionsProyectos.Forms
{
    public partial class UsuariosForm : Form
    {

        UsuarioDAO usuarioDAO;
        ProyectosDao pro;
        private DataTable promotorDataTable;
        public UsuariosForm()
        {
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
            pro = new ProyectosDao();
            CargarRoles();
            CargarEstados();
            CargarUsuarios();
            CargarEmpleados();
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            
            string correo = txtCorreo.Text.Trim();
            string contrasenia = txtContrasena.Text.Trim();
            string dui = txtDui.Text.Trim();
            int rolId = (int)comboRol.SelectedValue;
            int estadoId = (int)comboEstado.SelectedValue;

            
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasenia) ||
                string.IsNullOrEmpty(dui) || comboRol.SelectedIndex == -1 || comboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!ValidarContrasenia(contrasenia))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula y un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (usuarioDAO.CorreoExiste(correo))
            {
                MessageBox.Show("El correo ya está registrado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            int empleadoId = usuarioDAO.ObtenerEmpleadoIdPorDUI(dui);
            if (empleadoId == -1)
            {
                MessageBox.Show("El DUI ingresado no está registrado en el sistema(no hay empleado con ese Dui).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea crear este usuario?",
                                            "Confirmación",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
            {
                return; 
            }

            bool usuarioCreado = usuarioDAO.CrearUsuario(correo, contrasenia, rolId, empleadoId, estadoId);
            if (usuarioCreado)
            {
                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo crear el usuario. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarRoles()
        {
            try
            {
                DataTable roles = usuarioDAO.ObtenerRoles();
                if (roles.Rows.Count > 0)
                {
                    comboRol.DataSource = roles;
                    comboRol.DisplayMember = "Nombre";
                    comboRol.ValueMember = "Id";
                    comboRol.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarEstados()
        {
            try
            {
                DataTable estados = usuarioDAO.ObtenerEstados();
                if (estados.Rows.Count > 0)
                {
                    comboEstado.DataSource = estados;
                    comboEstado.DisplayMember = "Estado";
                    comboEstado.ValueMember = "IdEstado";
                    comboEstado.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarFormulario()
        {
            txtCorreo.Clear();
            txtContrasena.Clear();
            txtDui.Clear();
            comboRol.SelectedIndex = 1;
            comboEstado.SelectedIndex = 1;
        }

        private bool ValidarContrasenia(string contrasenia)
        {
            return contrasenia.Length >= 8 &&
                   contrasenia.Any(char.IsUpper) &&
                   contrasenia.Any(char.IsDigit);
        }



        public void CargarUsuarios()
        {
            try
            {
                DataTable usuariosData = usuarioDAO.ObtenerUsuarios();

                if (usuariosData.Rows.Count > 0)
                {

                    dgvUsuarios.DataSource = usuariosData;


                    dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                  //  dgvUsuarios.Columns[0].Visible = false;
                    //dgvUsuarios.Columns[5].HeaderText = "Promotor";
                }
                else
                {
                    MessageBox.Show("No se encontraron datos de Usuarios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarEmpleados()
        {
            try
            {

                promotorDataTable = usuarioDAO.ObtenerEmpleados();

                if (promotorDataTable.Rows.Count > 0)
                {

                    dtgEmpleados.DataSource = promotorDataTable;


                    dtgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                   // dtgEmpleados.Columns[0].Visible = false;

                }
                else
                {
                    MessageBox.Show("No se encontraron datos de Promotores. Puede que no haya promotores disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtBuscarDUI_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dtgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarDUI_TextChanged_1(object sender, EventArgs e)
        {
            if (promotorDataTable != null)
            {
                string filtro = txtBuscarDUI.Text.Trim().Replace("'", "''");
                promotorDataTable.DefaultView.RowFilter = string.Format("DUI LIKE '%{0}%'", filtro);
            }
        }
    }
}
