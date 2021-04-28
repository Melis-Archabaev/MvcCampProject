using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        //Context для доступа на базу данных
        Context db = new Context();
        //DbSet для изменение в базе данных(Это метод(DbContext))
        DbSet<Category>_object;
        public void Delete(Category c)
        {
            _object.Remove(c);
            c.SaveChanges();
        }

        public void Insert(Category c)
        {
            _object.Add(c);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category c)
        {
            c.SaveChanges();
        }
    }
}
