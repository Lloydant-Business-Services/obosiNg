using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
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
            modelBuilder.Entity<Users>().HasData(
                new Users() { IsActive = true, Id = 1, Email="Admin@obosi.ng",DateCreated= DateTime.Now,GenderId = 1,
                FirstName ="",IsSuspended = false,LastName="",Password="1234567",PhoneNumber = "070",RoleId = 1
                });
            modelBuilder.Entity<Gender>().HasData(
               new Gender() { IsActive = true, Id = 1, Name = "Male" },
               new Gender() { IsActive = true, Id = 2, Name = "Female" });
            modelBuilder.Entity<Unit_Type>().HasData(
                new Unit_Type() { Id = 1, Name = "Village" , IsActive = true },
                new Unit_Type() { Id = 2, Name = "Suburb", IsActive = true },
                new Unit_Type() { Id = 3, Name = "Palace" , IsActive = true },
                new Unit_Type() { Id = 4, Name = "Obosi development union (ODU)", IsActive = true },
                new Unit_Type() { Id = 5, Name = "ODU chapter" , IsActive = true },
                new Unit_Type() { Id = 6, Name = "ODU committee", IsActive = true },
                new Unit_Type() { Id = 7, Name = "Umunna" , IsActive = true },
                new Unit_Type() { Id = 8, Name = "Age Grade", IsActive = true },
                new Unit_Type() { Id = 9, Name = "Masquerade" , IsActive = true },
                new Unit_Type() { Id = 10, Name = "Monument", IsActive = true },
                new Unit_Type() { Id = 11, Name = "Dance Group" , IsActive = true },
                new Unit_Type() { Id = 12, Name = "Resource", IsActive = true });
            modelBuilder.Entity<Unit>().HasData(
               new Unit() { Id = 1,Name = "Umuota", About="",DateCreated=DateTime.Now,NeedsConfirmation = false,UnitTypeId = 1,BackGroundImageUrl = ""},
               new Unit() { Id = 2, Name = "Mmakwum", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 1, BackGroundImageUrl = "" },
               new Unit() { Id = 3, Name = "Uruowulu", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 1, BackGroundImageUrl = "" },
               new Unit() { Id = 4, Name = "Ugamuma", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 1, BackGroundImageUrl = "" },
               new Unit() { Id = 5, Name = "Ire", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 1, BackGroundImageUrl = "" },
               new Unit() { Id = 6, Name = "Lagos", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 7, Name = "Abuja", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 8, Name = "Port Harcourt", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 9, Name = "Aba", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 10, Name = "Abakaliki", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 11, Name = "Awka", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 12, Name = "Benin City", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 13, Name = "Enugu", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 14, Name = "Jos", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 15, Name = "Kaduna", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5 , BackGroundImageUrl = "" },
               new Unit() { Id = 16, Name = "Makurdi", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 17, Name = "Nnewi", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5 , BackGroundImageUrl = "" },
               new Unit() { Id = 18, Name = "Suleja", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5 , BackGroundImageUrl = "" },
               new Unit() { Id = 19, Name = "Warri", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 20, Name = "Umuota", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5 , BackGroundImageUrl = "" },
               new Unit() { Id = 21, Name = "Mmakwum", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 22, Name = "Uruowulu", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5 , BackGroundImageUrl = "" },
               new Unit() { Id = 23, Name = "Ugamuma", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 24, Name = "Ire", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5 , BackGroundImageUrl = "" },
               new Unit() { Id = 25, Name = "OWA UK", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 26, Name = "ODA USA", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5 , BackGroundImageUrl = "" },
               new Unit() { Id = 27, Name = "ODU South Africa", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 28, Name = "ODU Brazil", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 29, Name = "ODU Kuwait", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" }
                );
           
     
      
      
     
     
    
    
      
     
     
     
     
        modelBuilder.Entity<Category>().HasData(
                new Category() { Id=1,Name = "Politics", IsActive = true},
                   new Category() { Id = 2, Name = "Business & Economy", IsActive = true },
                    new Category() { Id = 3, Name = "Security & Defense", IsActive = true },
                     new Category() { Id = 4, Name = "Education", IsActive = true },
                      new Category() { Id = 5, Name = "Health", IsActive = true },
                       new Category() { Id = 6, Name = "Infrastructure", IsActive = true },
                        new Category() { Id = 7, Name = "Environment", IsActive = true },
                         new Category() { Id = 8, Name = "Science & Technology", IsActive = true },
                          new Category() { Id = 9, Name = "Sports", IsActive = true },
                           new Category() { Id = 10, Name = "Entertainment", IsActive = true },
                            new Category() { Id = 11, Name = "Fashion", IsActive = true },
                             new Category() { Id = 12, Name = "Food", IsActive = true },
                              new Category() { Id = 13, Name = "Travel & Tourism", IsActive = true },
                                new Category() { Id = 14, Name = "Diaspora", IsActive = true }
                );

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
        public DbSet<Builders_Boulevard> Builders_Boulevard { get; set;}
    }
}
