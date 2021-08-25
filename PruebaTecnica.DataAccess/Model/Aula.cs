using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PruebaTecnica.DataAccess.Model
{
   public class Aula
    {
        [Key]
        public int IdAula { get; set; }
        public string Nombre { get; set; }
        public int AsignaturaId { get; set; }
        [ForeignKey("AsignaturaId")]
        public virtual Asignatura Asignatura { get; set; }
        public int ProfesorId { get; set; }
        [ForeignKey("ProfesorId")]
        public virtual Profesor Profesor { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
