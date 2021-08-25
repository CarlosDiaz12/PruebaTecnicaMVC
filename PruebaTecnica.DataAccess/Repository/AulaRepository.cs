using PruebaTecnica.DataAccess.Data;
using PruebaTecnica.DataAccess.Interface;
using PruebaTecnica.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica.DataAccess.Repository
{
   public class AulaRepository : IRepository<Aula>
    {
        private readonly ApplicationDbContext _context;

        public AulaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Aula Create(Aula _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aula> GetAll()
        {
            throw new NotImplementedException();
        }

        public Aula GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Aula Update(Aula _object)
        {
            throw new NotImplementedException();
        }
    }
}
