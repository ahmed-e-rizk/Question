
using Microsoft.EntityFrameworkCore;
using Question.DbContext.Entities;

namespace Question.DbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Entities.Question> Questions { get; set; }
        public DbSet<UserResponse> UserResponses { get; set; }
        public DbSet<TestResult> TestResults { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
