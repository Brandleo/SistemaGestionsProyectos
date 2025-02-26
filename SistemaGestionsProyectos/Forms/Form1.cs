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
    public partial class PanelAdmin : Form
    {

        private string _usuario;
           
        public PanelAdmin(string usuario)
        {
            InitializeComponent();

            _usuario = usuario;

            labelUsuario.Text = "Bienvenido: " + _usuario;

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pruebas pruebas = new Pruebas();

            this.Hide();

            pruebas.ShowDialog();

            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado nuevaVentana = new Empleado();

            nuevaVentana.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
