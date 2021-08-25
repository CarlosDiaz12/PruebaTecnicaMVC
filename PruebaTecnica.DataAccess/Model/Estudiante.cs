using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnica.DataAccess.Model
{
   public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
