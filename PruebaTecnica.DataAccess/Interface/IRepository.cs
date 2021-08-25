﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica.DataAccess.Interface
{
   public interface IRepository<T>
    {
        public T Create(T _object);
        public T Update(T _object);
        public IEnumerable<T> GetAll();
        public void Delete(int Id);
        public T GetById(int Id);
    }
}
