using Microsoft.EntityFrameworkCore;
using TaskManagementAPI.Models;

namespace TaskManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }

        //model builder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            //this is fluent API syntax
            base.OnModelCreating(modelBuilder);

            //configure user-task relationship
            modelBuilder.Entity<User>()
                .HasMany(u => u.tasks)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.userId)
                .OnDelete(DeleteBehavior.Cascade);

            //configure indexes for better performance
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}
