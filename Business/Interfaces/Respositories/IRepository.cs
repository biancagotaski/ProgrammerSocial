using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Respositories
{
    /// <summary>
    /// Interface base para o CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository <T> where T : EntityBase
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        void Delete(T entity);
        void Update(T entity);
    }
}
