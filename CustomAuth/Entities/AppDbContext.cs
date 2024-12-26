using Microsoft.EntityFrameworkCore;

namespace CustomAuth.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  {   }
        public AppDbContext()   {   }
        public DbSet<UserAccount> UserAccounts { get; set; }  //Table will be named as UserAccounts in Db

        //This method will be also used to set the metadata of table eg. col properties like length or table relationships
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
