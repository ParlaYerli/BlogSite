using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Business.Abstract
{
    public interface IArticleService
    {
        List<Article> GetList();
        Article GetById(int articleId);
        void Add(Article article);
        void Delete(Article article);
        void Update(Article article);
    }
}
