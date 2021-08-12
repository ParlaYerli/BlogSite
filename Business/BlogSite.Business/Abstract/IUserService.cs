using BlogSite.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Business.Abstract
{
    public interface IUserService
    {
        User Get(string username, string password);
    }
}
