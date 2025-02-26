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
    public partial class FichaEmpleado : Form

    {
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        public FichaEmpleado()
        {
            InitializeComponent();
            dgvEmpleados.AllowUserToAddRows = false;
            this.Size = new Size(1000, 600); // Cambia los valores al tamaño deseado
    
            this.StartPosition = FormStartPosition.CenterScreen;






        }


        private void FichaEmpleado_Load(object sender, EventArgs e)
        {
            CargarListaEmpleados();

        }
        private void CargarListaEmpleados()
        {
            DataTable empleados = empleadoDAO.ObtenerEmpleados();
            dgvEmpleados.DataSource = empleados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                CargarListaEmpleados();
            }
            else
            {
                (dgvEmpleados.DataSource as DataTable).DefaultView.RowFilter =
                    $"Nombre LIKE '%{filtro}%' OR Apellido LIKE '%{filtro}%' OR Puesto LIKE '%{filtro}%'";
            }
        }

        private void CargarHistorialTareas(int empleadoId)
        {
            DataTable historial = empleadoDAO.ObtenerHistorialTareas(empleadoId);
            dgvHistorial.DataSource = historial;
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    

     

       

        private void dgvEmpleados_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            

        }

        private void dgvEmpleados_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FichaEmpleado_Resize_1(object sender, EventArgs e)
        {
            // Cuando la ventana se maximiza, el Panel ocupa el tamaño máximo disponible
         
           
        }

        private void dgvEmpleados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtCorreo.Text = fila.Cells["CorreoElectronico"].Value.ToString();
                txtDUI.Text = fila.Cells["DUI"].Value.ToString();
                txtPuesto.Text = fila.Cells["Puesto"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();

                int empleadoId = Convert.ToInt32(fila.Cells["Id"].Value);
                CargarHistorialTareas(empleadoId);

                // Confirm the action
                MessageBox.Show("Empleado cargado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
