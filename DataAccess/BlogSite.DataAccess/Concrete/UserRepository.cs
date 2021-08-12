using BlogSite.DataAccess.Abstract;
using BlogSite.DataAccess.Concrete.EntityFramework;
using BlogSite.Entity.Context;
using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSite.DataAccess.Concrete
{
    public class UserRepository : EfEntityRepositoryBase<User, BlogContext>, IUserRepository
    {
        private readonly BlogContext _context;
        public UserRepository(BlogContext context)
        {
            _context = context;
        }

        public User GetUser(string username, string password)
        {
            return _context.Users.Where(x => x.Name.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}
