using SistemaGestionsProyectos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionsProyectos.Forms
{
    public partial class Pruebas : Form
    {

        ProyectosDao proyectosDao;
        
        public Pruebas()
        {
            InitializeComponent();
            proyectosDao = new ProyectosDao();
            
            CargarProyectos();
           // CargarPromotores();
            CargarProyectosSinProm();
        }

        private void vERPROYECTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        public void CargarProyectos()
        {
            try
            {
                DataTable proyectoData = proyectosDao.VerProyectos() ;

                if (proyectoData.Rows.Count > 0)
                {
                   
                    dtgProyectos.DataSource = proyectoData;

                    
                    dtgProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgProyectos.Columns[0].Visible = false;
                    dtgProyectos.Columns[5].HeaderText = "Promotor";
                }
                else
                {
                    MessageBox.Show("No se encontraron datos de Proyectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarProyectosSinProm()
        {
            try
            {
                DataTable proyectoData = proyectosDao.VerProyectosSinPromotor();

                if (proyectoData.Rows.Count > 0)
                {

                    dgtProyectos.DataSource = proyectoData;


                    dgtProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgtProyectos.Columns[0].Visible = false;
                    dgtProyectos.Columns[5].HeaderText = "Promotor";


                }
                else
                {
                    MessageBox.Show("No se encontraron datos de Proyectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dtgProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreClave = txtNombreClave.Text.Trim();
            string denominacion = txtDenominacion.Text.Trim();
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

           
            if (string.IsNullOrEmpty(nombreClave) || string.IsNullOrEmpty(denominacion))
            {
                MessageBox.Show("Los campos no deben estar vacios.");
                return;
            }

            
            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha de finalización no puede ser anterior a la fecha de inicio.");
                return;
            }

            try
            {
                
                if (proyectosDao.ValidarNombreProyecto(nombreClave) == 1)
                {
                    MessageBox.Show("El nombre en clave ya existe. Por favor, elija otro nombre.");
                    return;
                }

               
                int resultado = proyectosDao.InsertProyecto(nombreClave, denominacion, fechaInicio, fechaFin);

                if (resultado > 0)
                {
                    MessageBox.Show("Proyecto creado correctamente.");
                    CargarProyectos();
                    CargarProyectosSinProm();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el proyecto. Intente nuevamente.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProyectos();
        }


        private void btnAgregar_Promotor_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnPromotor_Click(object sender, EventArgs e)
        {
            if (dgtProyectos.SelectedRows.Count > 0)
            {
                int proyectoId = Convert.ToInt32(dgtProyectos.SelectedRows[0].Cells["Id"].Value);
                string nombreProyecto = dgtProyectos.SelectedRows[0].Cells["NombreClave"].Value.ToString();

                AsignarPromotor promotor = new AsignarPromotor(proyectoId, nombreProyecto);
                promotor.ShowDialog();

              
                CargarProyectos();
                CargarProyectosSinProm();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proyecto antes de asignar un promotor.");
            }
        }




    }
}
