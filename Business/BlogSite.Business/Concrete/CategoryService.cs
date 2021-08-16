using BlogSite.Business.Abstract;
using BlogSite.DataAccess.Abstract;
using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSite.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public void Add(Category category)
        {
            _repository.Add(category);
        }

        public void Delete(Category category)
        {
            _repository.Delete(category);
        }

        public Category GetById(int categoryId)
        {
            return _repository.Get(i => i.Id == categoryId);
        }

        public List<Category> GetList()
        {
            return _repository.GetList().ToList();
        }

        public void Update(Category category)
        {
            _repository.Update(category);
        }
    }
}
