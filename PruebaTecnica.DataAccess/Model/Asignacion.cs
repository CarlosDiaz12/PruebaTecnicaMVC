using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PruebaTecnica.DataAccess.Model
{
   public class Asignacion
    {
        [Key]
        public int IdAsignacion { get; set; }
        public int AsignaturaId { get; set; }
        [ForeignKey("AsignaturaId")]
        public virtual Asignatura Asignatura { get; set; }
        public int EstudianteId { get; set; }
        [ForeignKey("EstudianteId")]
        public virtual Estudiante Estudiante { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
