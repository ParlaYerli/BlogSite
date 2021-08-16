using BlogSite.DataAccess.Abstract.EntityFramework;
using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.DataAccess.Abstract
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
    }
}
