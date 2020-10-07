using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}

//    public class AppUser
//    {
//        public int Id { get; set; }
//       
//        public string UserName { get; set; }
//    }