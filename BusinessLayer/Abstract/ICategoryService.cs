using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetCategoryList(Category category);
        Category GetById(int id);
        List<Category> GetCategoryListByQuery(Expression<Func<Category,bool>>method);
        Category GetCategoryByQuery(Expression<Func<Category,bool>>method);
    }
}
