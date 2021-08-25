using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnica.DataAccess.Model
{
   public class Asignatura
    {
        [Key]
        public int IdAsignatura { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
