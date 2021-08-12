using BlogSite.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSite.Entity.Context
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new BlogContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Users.Count() == 0)
                {
                    context.Users.AddRange(Users);
                    context.SaveChanges();
                }
              
            }
        }
        private static User[] Users = {
            new User(){ Name="parla",  Role="user", Password="parla"},
            new User(){ Name="hazal", Role="user", Password="parla"}
            };
    }
}
