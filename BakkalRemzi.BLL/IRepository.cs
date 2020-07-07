using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalRemzi.BLL
{
    public interface IRepository<T>
    {
        List<T> getAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T selectById(int Id);

    }
}
