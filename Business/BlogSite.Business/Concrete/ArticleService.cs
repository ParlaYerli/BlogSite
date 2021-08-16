using BlogSite.Business.Abstract;
using BlogSite.DataAccess.Abstract;
using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSite.Business.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _repository;
        public ArticleService(IArticleRepository repository)
        {
            _repository = repository;
        }

        public void Add(Article article)
        {
            _repository.Add(article);
        }

        public void Delete(Article article)
        {
            _repository.Delete(article);
        }

        public Article GetById(int articleId)
        {
            return _repository.Get(i=>i.Id==articleId);
        }

        public List<Article> GetList()
        {
            return _repository.GetList().ToList();
        }

        public void Update(Article article)
        {
            _repository.Update(article);
        }
    }
}
