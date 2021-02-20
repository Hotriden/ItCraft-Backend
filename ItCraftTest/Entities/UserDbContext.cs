using Microsoft.EntityFrameworkCore;

namespace ItCraftTest.Entities
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new { Id = 1, Name = "Vasya", Active = false },
                new { Id = 2, Name = "Petya", Active = false },
                new { Id = 3, Name = "Katya", Active = false },
                new { Id = 4, Name = "Olya", Active = false },
                new { Id = 5, Name = "Masha", Active = false },
                new { Id = 6, Name = "Grisha", Active = false },
                new { Id = 7, Name = "John", Active = false },
                new { Id = 8, Name = "Pavel", Active = false },
                new { Id = 9, Name = "Rita", Active = false },
                new { Id = 10, Name = "Sveta", Active = false }
            );
        }

    }
}
