using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Obosi.ng.Domain.Entity;
using System.Text.RegularExpressions;

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
                new Users() { IsActive = true, Id = 1, Email = "Admin@obosi.ng", DateCreated = DateTime.Now, GenderId = 1,
                    FirstName = "", IsSuspended = false, LastName = "", Password = "1234567", PhoneNumber = "070", RoleId = 1
                });
            modelBuilder.Entity<Gender>().HasData(
               new Gender() { IsActive = true, Id = 1, Name = "Male" },
               new Gender() { IsActive = true, Id = 2, Name = "Female" });
            modelBuilder.Entity<Unit_Type>().HasData(
                new Unit_Type() { Id = 1, Name = "Village", IsActive = true },
                new Unit_Type() { Id = 2, Name = "Suburb", IsActive = true },
                new Unit_Type() { Id = 3, Name = "Palace", IsActive = true },
                new Unit_Type() { Id = 4, Name = "Obosi development union (ODU)", IsActive = true },
                new Unit_Type() { Id = 5, Name = "ODU chapter", IsActive = true },
                new Unit_Type() { Id = 6, Name = "ODU committee", IsActive = true },
                new Unit_Type() { Id = 7, Name = "Umunna", IsActive = true },
                new Unit_Type() { Id = 8, Name = "Age Grade", IsActive = true },
                new Unit_Type() { Id = 9, Name = "Masquerade", IsActive = true },
                new Unit_Type() { Id = 10, Name = "Monument", IsActive = true },
                new Unit_Type() { Id = 11, Name = "Dance Group", IsActive = true },
                new Unit_Type() { Id = 12, Name = "Resource", IsActive = true },
                new Unit_Type() { Id = 13, Name = "Ime Nne", IsActive = true },
                  new Unit_Type() { Id = 14, Name = "Aka", IsActive = true },
                     new Unit_Type() { Id = 15, Name = "Personalities", IsActive = true },
                        new Unit_Type() { Id = 16, Name = "Igwes Cabinent", IsActive = true },
                           new Unit_Type() { Id = 17, Name = "Schools", IsActive = true },
                              new Unit_Type() { Id = 18, Name = "Hotels", IsActive = true },
                                 new Unit_Type() { Id = 19, Name = "Churches", IsActive = true },
                                    new Unit_Type() { Id = 20, Name = "Ito-Ogbo", IsActive = true },
                                       new Unit_Type() { Id = 21, Name = "New Yam Festival", IsActive = true },
                                          new Unit_Type() { Id = 22, Name = "Festivals", IsActive = true },
                                             new Unit_Type() { Id = 23, Name = "Landmarks", IsActive = true },
                                                new Unit_Type() { Id = 24, Name = "Services And Resources", IsActive = true }
                );
            modelBuilder.Entity<Unit>().HasData(
               new Unit() { Id = 1, Name = "Umuota", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 1, BackGroundImageUrl = "" },
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
               new Unit() { Id = 15, Name = "Kaduna", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 16, Name = "Makurdi", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 17, Name = "Nnewi", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 18, Name = "Suleja", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 19, Name = "Warri", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 20, Name = "Umuota", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 21, Name = "Mmakwum", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 22, Name = "Uruowulu", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 23, Name = "Ugamuma", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 24, Name = "Ire", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 25, Name = "OWA UK", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 26, Name = "ODA USA", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 27, Name = "ODU South Africa", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 28, Name = "ODU Brazil", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" },
               new Unit() { Id = 29, Name = "ODU Kuwait", About = "", DateCreated = DateTime.Now, NeedsConfirmation = false, UnitTypeId = 5, BackGroundImageUrl = "" }


               );













            modelBuilder.Entity<Category>().HasData(
                    new Category() { Id = 1, Name = "Culture and Traditions", IsActive = true },
                       new Category() { Id = 2, Name = "Community Events and News", IsActive = true },
                        new Category() { Id = 3, Name = "Historical Insights", IsActive = true },
                         new Category() { Id = 4, Name = "Local Business Spotlights", IsActive = true },
                          new Category() { Id = 5, Name = "Tourism", IsActive = true },
                           new Category() { Id = 6, Name = "Health and Wellness", IsActive = true },
                            new Category() { Id = 7, Name = "Education", IsActive = true },
                             new Category() { Id = 8, Name = "Art and Creativity", IsActive = true },
                              new Category() { Id = 9, Name = "Food and nutrition", IsActive = true },
                               new Category() { Id = 10, Name = "Community Initiatives", IsActive = true },
                                new Category() { Id = 11, Name = "Religion", IsActive = true },
                                 new Category() { Id = 12, Name = "Politics", IsActive = true },
                                  new Category() { Id = 13, Name = "Government Initiatives", IsActive = true },
                                    new Category() { Id = 14, Name = "Science and Technology", IsActive = true },
                                     new Category() { Id = 15, Name = "Education", IsActive = true },
                                      new Category() { Id = 16, Name = "Jobs", IsActive = true },
                                       new Category() { Id = 17, Name = "Love, life, and family", IsActive = true },
                                        new Category() { Id = 18, Name = "Sports and youth development", IsActive = true }
                    );

            modelBuilder.Entity<MenuGroup>().HasData(
             new MenuGroup() { Id = 1, Name = "MG_Users", Active = true }          
            ); 
            modelBuilder.Entity<Menu>().HasData(
                 new Menu() { Id = 1, Controller = "User", ActionName = "Index", DisplayName = "Users", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 2, Controller = "Unit", ActionName = "Index", DisplayName = "Unit Management", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 3, Controller = "Blog", ActionName = "Index", DisplayName = "Blog Management", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 4, Controller = "News", ActionName = "Index", DisplayName = "News Management", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 5, Controller = "User", ActionName = "UnApproveUsers", DisplayName = "Approve Users", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 6, Controller = "Boulevard", ActionName = "BoulevardList", DisplayName = "Builders Boulevard", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 7, Controller = "Calender", ActionName = "index", DisplayName = "Calendar", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 8, Controller = "PictureAsset", ActionName = "index", DisplayName = "Picture Assets", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 9, Controller = "VideoAssets", ActionName = "index", DisplayName = "Video Assets", MenuGroupId = 1, Active = true },
                 new Menu() { Id = 10, Controller = "Executive", ActionName = "index", DisplayName = "Executives", MenuGroupId = 1, Active = true },

                 new Menu() { Id = 11, Controller = "About", ActionName = "Index", DisplayName = "About", MenuGroupId = 1, Active = true }
             );
            modelBuilder.Entity<MenuInRole>().HasData(
                    new MenuInRole() {Id =1, MenuId = 1, RoleId = 1 },
                    new MenuInRole() { Id = 2, MenuId = 2, RoleId = 1 },
                    new MenuInRole() { Id = 3, MenuId = 3, RoleId = 1 },
                    new MenuInRole() { Id = 4, MenuId = 4, RoleId = 1 },
                    new MenuInRole() {Id = 5, MenuId = 5, RoleId = 1 },
                    new MenuInRole() {Id = 6, MenuId = 6, RoleId = 1 },
                    new MenuInRole() {Id = 7, MenuId = 7, RoleId = 1 },
                    new MenuInRole() {Id = 8, MenuId = 8, RoleId = 1 },
                    new MenuInRole() {Id = 9, MenuId = 9, RoleId = 1 },
                    new MenuInRole() {Id = 10, MenuId = 10, RoleId = 1 },
                    new MenuInRole() { Id = 11, MenuId = 11, RoleId = 1 }
                );




        }


        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Blogs_Comment> Blogs_Comment { get; set; }
        public DbSet<Blogs_Update> Blogs_Update { get; set; }
        public DbSet<Calender_Assets> Calender_Assets { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Executive> Executive { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Personality> Personality { get; set; }
        public DbSet<Member_Unit> Member_Unit { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<News_Comment> News_Comment { get; set; }
        public DbSet<News_Update> News_Update { get; set; }
        public DbSet<Picture_Assets> Picture_Assets { get; set; }
        public DbSet<Reasons_For_Suspension> Reasons_For_Suspension { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Unit_Type> Unit_Type { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Video_Assets> Video_Assets { get; set; }
        public DbSet<Builders_Boulevard> Builders_Boulevard { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuGroup> MenuGroup { get; set; }
        public DbSet<MenuInRole> MenuInRole { get; set; }
        public DbSet<About> About { get; set; }
    }
}
