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
    public partial class AsignarPromotor : Form
    {

        ProyectosDao pro;
        private DataTable promotorDataTable;

        private int proyectoId;
        private string nombreProyecto;
        public AsignarPromotor(int proyectoId, string nombreProyecto)
        {
            InitializeComponent();
            pro = new ProyectosDao();
            CargarPromotores();
            this.proyectoId = proyectoId;
            this.nombreProyecto = nombreProyecto;

        }




        public void CargarPromotores()
        {
            try
            {
                
                 promotorDataTable = pro.verPromotoresDisponibles();

                if (promotorDataTable.Rows.Count > 0)
                {

                    dtgPromotores.DataSource = promotorDataTable;


                    dtgPromotores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgPromotores.Columns[0].Visible = false;

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













        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dtgPromotores.SelectedRows.Count > 0)
            {
                int usuarioId = Convert.ToInt32(dtgPromotores.SelectedRows[0].Cells["Id"].Value);
                string nombrePromotor = dtgPromotores.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string duiPromotor = dtgPromotores.SelectedRows[0].Cells["DUI"].Value.ToString();

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de asignar el promotor {nombrePromotor} (DUI: {duiPromotor}) al proyecto {nombreProyecto}?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    bool asignado = pro.AsignarPromotorAProyecto(proyectoId, usuarioId);

                    if (asignado)
                    {
                        MessageBox.Show("Promotor asignado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo asignar el promotor. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un promotor para asignarlo al proyecto.");
            }
        }

        private void txtBuscarDUI_TextChanged(object sender, EventArgs e)
        {
            if (promotorDataTable != null)
            {
                string filtro = txtBuscarDUI.Text.Trim().Replace("'", "''"); 
                promotorDataTable.DefaultView.RowFilter = string.Format("DUI LIKE '%{0}%'", filtro);
            }
        }

        private void dtgPromotores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
