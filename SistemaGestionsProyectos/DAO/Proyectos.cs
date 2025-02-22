using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionsProyectos.Clases
{
    internal class Proyectos
    {


        public int Id { get; set; }
        public string NombreClave { get; set; }
        public string DenominacionComercial { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int? UsuarioId { get; set; }



    }
}
