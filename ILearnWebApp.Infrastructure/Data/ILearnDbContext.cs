using ILearnWebApp.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ILearnWebApp.Infrastructure.Data
{
    public class ILearnDbContext : DbContext
    {
        public ILearnDbContext() { }

        public ILearnDbContext(DbContextOptions<ILearnDbContext> options)
            : base(options) { }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseRegistration> CourseRegistrations { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Check if configuration is available
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ILearnWebApp.Web/"))
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Account configuration
            builder.Entity<Account>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.HasMany(a => a.Lecturers)
                    .WithOne(l => l.Account)
                    .HasForeignKey(l => l.AccountId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(a => a.Students)
                    .WithOne(s => s.Account)
                    .HasForeignKey(s => s.AccountId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Category configuration
            builder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasMany(c => c.Courses)
                    .WithOne(c => c.Category)
                    .HasForeignKey(c => c.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Course configuration
            builder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(c => c.Lecturer)
                    .WithMany(l => l.Courses)
                    .HasForeignKey(c => c.LecturerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.Category)
                    .WithMany(c => c.Courses)
                    .HasForeignKey(c => c.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Video configuration
            builder.Entity<Video>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(v => v.Course)
                    .WithMany(c => c.Videos)
                    .HasForeignKey(v => v.CourseId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Discount configuration
            builder.Entity<Discount>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            // Lecturer configuration
            builder.Entity<Lecturer>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasMany(c => c.Courses)
                    .WithOne(l => l.Lecturer)
                    .HasForeignKey(c => c.LecturerId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Student configuration
            builder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            // CourseRegistration configuration
            builder.Entity<CourseRegistration>(entity =>
            {
                entity.HasKey(cr => new { cr.StudentId, cr.CourseId });

                entity.HasOne(cr => cr.Course)
                    .WithMany(c => c.CourseRegistrations)
                    .HasForeignKey(cr => cr.CourseId)
                    .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.NoAction

                entity.HasOne(cr => cr.Student)
                    .WithMany(s => s.CourseRegistrations)
                    .HasForeignKey(cr => cr.StudentId)
                    .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.NoAction
            });

            base.OnModelCreating(builder);
        }


    }
}
