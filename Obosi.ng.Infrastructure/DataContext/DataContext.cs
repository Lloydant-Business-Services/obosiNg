using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(f => f.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(
                new Role() { IsActive = true, Id = 1, Name = "Administrator" },
                new Role() { IsActive = true, Id = 2, Name = "User" });
            modelBuilder.Entity<Gender>().HasData(
               new Role() { IsActive = true, Id = 1, Name = "Male" },
               new Role() { IsActive = true, Id = 2, Name = "Female" });
            modelBuilder.Entity<Unit_Type>().HasData(
                new Unit_Type() { Id = 1, Name = "Village" },
                new Unit_Type() { Id = 2, Name = "Suburb" },
                new Unit_Type() { Id = 3, Name = "Palace" },
                new Unit_Type() { Id = 4, Name = "Obosi development union (ODU)" },
                new Unit_Type() { Id = 5, Name = "ODU chapter" },
                new Unit_Type() { Id = 6, Name = "ODU committee" },
                new Unit_Type() { Id = 7, Name = "Umunna" },
                new Unit_Type() { Id = 8, Name = "Age Grade" },
                new Unit_Type() { Id = 9, Name = "Masquerade" },
                new Unit_Type() { Id = 10, Name = "Monument" },
                new Unit_Type() { Id = 11, Name = "Dance Group" },
                new Unit_Type() { Id = 12, Name = "Resource" });
        }


        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Blogs_Comment> Blogs_Comment { get; set;}
        public DbSet<Blogs_Update> Blogs_Update { get; set;}
        public DbSet<Calender_Assets> Calender_Assets { get; set;}
        public DbSet<Category> Category { get; set;}
        public DbSet<Executive> Executive { get; set;}
        public DbSet<Gender> Gender { get; set;}
        public DbSet<ImeNne> ImeNne { get; set;}
        public DbSet<Member_Unit> Member_Unit { get; set;}
        public DbSet<News> News { get; set;}
        public DbSet<News_Comment> News_Comment { get; set;}    
        public DbSet<News_Update> News_Update { get; set;}
        public DbSet<Picture_Assets> Picture_Assets { get; set;}
        public DbSet<Reasons_For_Suspension> Reasons_For_Suspension { get; set; }
        public DbSet<Role> Role { get; set;}
        public DbSet<Unit> Unit { get; set;}
        public DbSet<Unit_Type> Unit_Type { get; set;}
        public DbSet<Users> Users { get; set; }
        public DbSet<Video_Assets> Video_Assets { get; set;}    
    }
}
