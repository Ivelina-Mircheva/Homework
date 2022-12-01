using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Abstract
{
    public interface IRepository<T> where T : class
    {
        T GetById(Guid id);
        List<T> All();
        void Create(T entity);
        void Update(Guid id, T entity);
        void Delete(Guid id);
    }
}
