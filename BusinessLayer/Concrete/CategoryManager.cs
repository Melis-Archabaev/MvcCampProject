using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repos = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repos.List();
        }
        public void CategoryAddBL(Category p)
        {
            //if(p.CategoryName == "" || p.CategoryName.Length<=3 ||p.CategoryDescription == "" ||p.CategoryName.Length >=50)
            //{
            //    //Error Message
            //}
            //else
            //{
                    repos.Insert(p);
            //}
        }
    }
}
