using PruebaTecnica.DataAccess.Data;
using PruebaTecnica.DataAccess.Interface;
using PruebaTecnica.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica.DataAccess.Repository
{
   public class EstudianteRepository : IRepository<Estudiante>
    {
        private readonly ApplicationDbContext _context;

        public EstudianteRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Estudiante Create(Estudiante _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estudiante> GetAll()
        {
            throw new NotImplementedException();
        }

        public Estudiante GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Estudiante Update(Estudiante _object)
        {
            throw new NotImplementedException();
        }
    }
}
