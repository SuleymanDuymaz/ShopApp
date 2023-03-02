using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class EFProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using var context = new Context();
            return context.Set<Product>().ToList(); 
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            using var context = new Context();
            return context.Set<Product>().Where(filter).ToList();
        }
    }
}
