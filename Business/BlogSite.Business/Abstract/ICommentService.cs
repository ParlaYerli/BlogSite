using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetList();
        Comment GetById(int commentId);
        void Add(Comment comment);
        void Delete(Comment comment);
        void Update(Comment comment);
    }
}
