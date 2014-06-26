using System.Data.Entity;

using User.CRUD.Models;

namespace User.CRUD.Infrastructure
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection") { }

        public DbSet<User.CRUD.Models.User> Users { get; set; }
    }
}