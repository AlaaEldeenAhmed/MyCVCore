using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object Id);
    }
}
