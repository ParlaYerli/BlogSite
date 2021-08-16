using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        Category GetById(int categoryId);
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
