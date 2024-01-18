using Microsoft.EntityFrameworkCore;
using Obosi.ng.Models.EntityModel;

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
                new Role() { Active = true, Id = 1, Name = "Administrator" },
                new Role() { Active = true, Id = 2, Name = "User" });
            modelBuilder.Entity<UnitType>().HasData(
                new UnitType() { Id = 1, Name = "Village" },
                new UnitType() { Id = 2, Name = "Suburb" },
                new UnitType() { Id = 3, Name = "Palace" },
                new UnitType() { Id = 4, Name = "Obosi development union (ODU)" },
                new UnitType() { Id = 5, Name = "ODU chapter" },
                new UnitType() { Id = 6, Name = "ODU committee" },
                new UnitType() { Id = 7, Name = "Umunna" },
                new UnitType() { Id = 8, Name = "Age Grade" },
                new UnitType() { Id = 9, Name = "Masquerade" },
                new UnitType() { Id = 10, Name = "Monument" },
                new UnitType() { Id = 11, Name = "Dance Group" },
                new UnitType() { Id = 12, Name = "Resource" });
        }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogComment> BlogComment { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Executive> Executive { get; set; }
        public DbSet<NewsArticle> NewsArticle { get; set; }    
        public DbSet<NewsCategory> NewsCategory { get; set; }   
        public DbSet<NewsComment> NewsComment { get; set; } 
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostWallComment> PostWallComment { get; set; }
        public DbSet<Role> Role { get; set; }   
        public DbSet<Unit> Unit { get; set; }
        public DbSet<UnitType> UnitType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Video> Video { get; set; } 
    }
}
