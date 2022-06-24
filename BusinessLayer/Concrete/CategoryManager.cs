using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository _eFCategoryRepository;

        public CategoryManager()
        {
            _eFCategoryRepository = new EFCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {

            _eFCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _eFCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _eFCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return _eFCategoryRepository.GetById(id);
        }

        public Category GetCategoryByQuery(Expression<Func<Category, bool>> method)
        {
            return _eFCategoryRepository.Get(method);
        }

        public List<Category> GetCategoryList(Category category)
        {
            return _eFCategoryRepository.GetAll(category);
        }

        public List<Category> GetCategoryListByQuery(Expression<Func<Category, bool>> method)
        {
            return _eFCategoryRepository.GetByQuery(method);
        }
    }
}
