using BlogSite.DataAccess.Abstract.EntityFramework;
using BlogSite.Entity.Context;
using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogSite.DataAccess.Abstract
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
       
    }
}
