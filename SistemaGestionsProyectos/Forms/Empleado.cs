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
            txtDUI.Text = "00000000-0";  // Texto de referencia
            txtDUI.ForeColor = Color.Gray; // Color gris para indicar que es un ejemplo
            txtDUI.GotFocus += txtDUI_GotFocus; // Evento cuando el usuario hace clic en el TextBox
            txtDUI.LostFocus += txtDUI_LostFocus;
            txtDUI.KeyPress += txtDUI_KeyPress; // Evento para validar cada tecla presionada
        }

        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();

        private void txtDUI_GotFocus(object sender, EventArgs e)
        {
            if (txtDUI.Text == "00000000-0")
            {
                txtDUI.Text = "";
                txtDUI.ForeColor = Color.Black; // Cambia el color a negro cuando el usuario empieza a escribir
            }
        }

        private void txtDUI_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDUI.Text))
            {
                txtDUI.Text = "00000000-0";  // Si el usuario no ingresó nada, vuelve el placeholder
                txtDUI.ForeColor = Color.Gray;
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Solo permite números y teclas de control (como backspace)
            }

            if (txtDUI.Text.Length == 8 && !char.IsControl(e.KeyChar))
            {
                txtDUI.Text += "-"; // Inserta el guion automáticamente después de 8 números
                txtDUI.SelectionStart = txtDUI.Text.Length; // Mueve el cursor al final
            }

            if (txtDUI.Text.Length > 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // No permite más de 9 caracteres (8 números + 1 guion)
            }
        }

        private void LimpiarFormulario()
        {
            txtDUI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtHabilidades.Clear();
            txtPuesto.Clear();
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
                string puesto = txtPuesto.Text.Trim();

                if (string.IsNullOrWhiteSpace(dui) || string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(puesto))
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

                bool resultadoInsercion = empleadoDAO.InsertarEmpleado(dui, nombre, apellido, direccion, habilidades,puesto);

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
