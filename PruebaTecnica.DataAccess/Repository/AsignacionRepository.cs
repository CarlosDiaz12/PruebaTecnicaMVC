using PruebaTecnica.DataAccess.Data;
using PruebaTecnica.DataAccess.Interface;
using PruebaTecnica.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica.DataAccess.Repository
{
   public class AsignacionRepository : IRepository<Asignacion>
    {
        private readonly ApplicationDbContext _context;

        public AsignacionRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Asignacion Create(Asignacion _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Asignacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Asignacion GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Asignacion Update(Asignacion _object)
        {
            throw new NotImplementedException();
        }
    }
}
