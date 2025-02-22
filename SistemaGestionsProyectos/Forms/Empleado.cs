using SistemaGestionsProyectos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionsProyectos.Forms
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();


        private void LimpiarFormulario()
        {
            txtDUI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtHabilidades.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dui = txtDUI.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string habilidades = txtHabilidades.Text.Trim();

                if (string.IsNullOrWhiteSpace(dui) || string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(direccion))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarDUI(dui))
                {
                    MessageBox.Show("El DUI ingresado no tiene el formato correcto (00000000-0).", "Error de Formato",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea agregar este empleado?",
                                                         "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool resultadoInsercion = empleadoDAO.InsertarEmpleado(dui, nombre, apellido, direccion, habilidades);

                if (resultadoInsercion)
                {
                    MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private bool ValidarDUI(string dui)
        {
            string patronDUI = @"^\d{8}-\d{1}$"; 
            return Regex.IsMatch(dui, patronDUI);
        }

       
    }
    
}
