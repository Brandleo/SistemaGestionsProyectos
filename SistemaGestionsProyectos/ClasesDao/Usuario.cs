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
        private string contrasenia;
        private int estadoId;
        private int rolId;
        private int empleado_id;
        private int IntentosFallidos;
        private DateTime BloqueadoHasta;

        public Usuario() 
        {
        }

        public Usuario(int id, string correo, string contrasenia, int estadoId, int rolId, int empleado_id, int intentosFallidos, DateTime bloqueadoHasta)
        {
            this.id = id;
            this.correo = correo;
            this.contrasenia = contrasenia;
            this.estadoId = estadoId;
            this.rolId = rolId;
            this.empleado_id = empleado_id;
            IntentosFallidos = intentosFallidos;
            BloqueadoHasta = bloqueadoHasta;
        }

        public int Id { get => id; set => id = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int EstadoId { get => estadoId; set => estadoId = value; }
        public int RolId { get => rolId; set => rolId = value; }
        public int Empleado_id { get => empleado_id; set => empleado_id = value; }
        public int IntentosFallidos1 { get => IntentosFallidos; set => IntentosFallidos = value; }
        public DateTime BloqueadoHasta1 { get => BloqueadoHasta; set => BloqueadoHasta = value; }
    }
}
