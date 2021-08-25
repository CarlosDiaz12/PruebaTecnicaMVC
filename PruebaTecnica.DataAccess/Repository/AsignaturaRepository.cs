using PruebaTecnica.DataAccess.Data;
using PruebaTecnica.DataAccess.Interface;
using PruebaTecnica.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica.DataAccess.Repository
{
   public class AsignaturaRepository : IRepository<Asignatura>
    {
        private readonly ApplicationDbContext _context;

        public AsignaturaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Asignatura Create(Asignatura _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Asignatura> GetAll()
        {
            throw new NotImplementedException();
        }

        public Asignatura GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Asignatura Update(Asignatura _object)
        {
            throw new NotImplementedException();
        }
    }
}
