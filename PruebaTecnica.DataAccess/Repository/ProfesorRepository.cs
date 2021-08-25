using PruebaTecnica.DataAccess.Data;
using PruebaTecnica.DataAccess.Interface;
using PruebaTecnica.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica.DataAccess.Repository
{
   public class ProfesorRepository : IRepository<Profesor>
    {
        private readonly ApplicationDbContext _context;

        public ProfesorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Profesor Create(Profesor _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profesor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Profesor GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Profesor Update(Profesor _object)
        {
            throw new NotImplementedException();
        }
    }
}
