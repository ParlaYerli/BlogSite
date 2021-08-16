using BlogSite.DataAccess.Abstract;
using BlogSite.DataAccess.Concrete.EntityFramework;
using BlogSite.Entity.Context;
using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogSite.DataAccess.Concrete
{
    public class ArticleRepository : EfEntityRepositoryBase<Article, BlogContext>, IArticleRepository
    {
       
    }
}
