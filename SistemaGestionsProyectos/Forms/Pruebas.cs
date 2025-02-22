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
    public partial class Pruebas : Form
    {

        ProyectosDao proyectosDao;
        public Pruebas()
        {
            InitializeComponent();
            proyectosDao = new ProyectosDao();
            CargarProyectos();
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


        private void dtgProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
