using Microsoft.EntityFrameworkCore;
using PruebaTecnica.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Asignacion> Asignacion { get; set; }
        public DbSet<Asignatura> Asignatura { get; set; }

    }
}
