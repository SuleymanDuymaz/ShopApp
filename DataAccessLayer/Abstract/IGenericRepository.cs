using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {

        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> List();
        T GetById(int id);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
