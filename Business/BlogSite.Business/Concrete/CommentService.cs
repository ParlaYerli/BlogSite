using BlogSite.Business.Abstract;
using BlogSite.DataAccess.Abstract;
using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSite.Business.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _repository;

        public CommentService(ICommentRepository repository)
        {
            _repository = repository;
        }

        public void Add(Comment comment)
        {
            _repository.Add(comment);
        }

        public void Delete(Comment comment)
        {
            _repository.Delete(comment);
        }

        public Comment GetById(int commentId)
        {
            return _repository.Get(i => i.Id == commentId);
        }

        public List<Comment> GetList()
        {
            return _repository.GetList().ToList();
        }

        public void Update(Comment comment)
        {
            _repository.Update(comment);
        }
    }
}
