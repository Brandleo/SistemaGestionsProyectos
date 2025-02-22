using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionsProyectos.ClasesDao
{
    public class Usuario
    {
        private int id;
        private string correo;
        private string contraseña;
        private bool estado;
        private int rolId;

        public Usuario()
        {

        }

        public Usuario(int id, string correo, string contraseña, bool estado, int rolId)
        {
            this.id = id;
            this.correo = correo;
            this.contraseña = contraseña;
            this.estado = estado;
            this.rolId = rolId;
        }

        public int Id { get => id; set => id = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int RolId { get => rolId; set => rolId = value; }
    }
}
