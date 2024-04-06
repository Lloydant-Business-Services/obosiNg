using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Builders_Boulevard",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builders_Boulevard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit_Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuGroupId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_MenuGroup_MenuGroupId",
                        column: x => x.MenuGroupId,
                        principalTable: "MenuGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsSuspended = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_TypeId = table.Column<int>(type: "int", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackGroundImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NeedsConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    CanHaveMembers = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Unit_Type_Unit_TypeId",
                        column: x => x.Unit_TypeId,
                        principalTable: "Unit_Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuInRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuInRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuInRole_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuInRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BackgroundImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    DateApproved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BackgroundImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    DateApproved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_News_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personality",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    PortFolio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personality_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reasons_For_Suspension",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<long>(type: "bigint", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResolutionNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateResolved = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reasons_For_Suspension", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reasons_For_Suspension_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calender_Assets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calender_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calender_Assets_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Executive",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Executive_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Executive_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Member_Unit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateApproved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Unit_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_Unit_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Picture_Assets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Picture_Assets_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitAdmin",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitAdmin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitAdmin_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitAdmin_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Video_Assets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Assets_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Village",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Village", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Village_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blogs_Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Comment_Blogs_BlogsId",
                        column: x => x.BlogsId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Comment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blogs_Update",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogsId = table.Column<int>(type: "int", nullable: false),
                    Updates = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs_Update", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Update_Blogs_BlogsId",
                        column: x => x.BlogsId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Update_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News_Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Comment_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_News_Comment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News_Update",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    Updates = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News_Update", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Update_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_News_Update_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    VillageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aka_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aka_Village_VillageId",
                        column: x => x.VillageId,
                        principalTable: "Village",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Umunna",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    AkaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Umunna", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Umunna_Aka_AkaId",
                        column: x => x.AkaId,
                        principalTable: "Aka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Umunna_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imenne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UmunnaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imenne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imenne_Umunna_UmunnaId",
                        column: x => x.UmunnaId,
                        principalTable: "Umunna",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imenne_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Culture and Traditions" },
                    { 2, true, "Community Events and News" },
                    { 3, true, "Historical Insights" },
                    { 4, true, "Local Business Spotlights" },
                    { 5, true, "Tourism" },
                    { 6, true, "Health and Wellness" },
                    { 7, true, "Education" },
                    { 8, true, "Art and Creativity" },
                    { 9, true, "Food and nutrition" },
                    { 10, true, "Community Initiatives" },
                    { 11, true, "Religion" },
                    { 12, true, "Politics" },
                    { 13, true, "Government Initiatives" },
                    { 14, true, "Science and Technology" },
                    { 15, true, "Education" },
                    { 16, true, "Jobs" },
                    { 17, true, "Love, life, and family" },
                    { 18, true, "Sports and youth development" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Male" },
                    { 2, true, "Female" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroup",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[] { 1, true, "MG_Users" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Administrator" },
                    { 2, true, "User" },
                    { 3, true, "Writer" },
                    { 4, true, "Unit Admin" }
                });

            migrationBuilder.InsertData(
                table: "Unit_Type",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Village" },
                    { 2, true, "Suburb" },
                    { 3, true, "Palace" },
                    { 4, true, "Obosi development union (ODU)" },
                    { 5, true, "ODU chapter" },
                    { 6, true, "ODU committee" },
                    { 7, true, "Umunna" },
                    { 8, true, "Age Grade" },
                    { 9, true, "Masquerade" },
                    { 10, true, "Monument" },
                    { 11, true, "Dance Group" },
                    { 12, true, "Resource" },
                    { 13, true, "Ime Nne" },
                    { 14, true, "Aka" },
                    { 15, true, "Personalities" },
                    { 16, true, "Igwes Cabinent" },
                    { 17, true, "Schools" },
                    { 18, true, "Hotels" },
                    { 19, true, "Churches" },
                    { 20, true, "Ito-Ogbo" },
                    { 21, true, "New Yam Festival" },
                    { 22, true, "Festivals" },
                    { 23, true, "Landmarks" },
                    { 24, true, "Services And Resources" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "ActionName", "Active", "Controller", "DisplayName", "MenuGroupId" },
                values: new object[,]
                {
                    { 1, "Index", true, "User", "Users", 1 },
                    { 2, "Index", true, "Unit", "Unit Management", 1 },
                    { 3, "Index", true, "Blog", "Blog Management", 1 },
                    { 4, "Index", true, "News", "News Management", 1 },
                    { 5, "UnApproveUsers", true, "User", "Approve Users", 1 },
                    { 6, "BoulevardList", true, "Boulevard", "Builders Boulevard", 1 },
                    { 7, "index", true, "Calender", "Calendar", 1 },
                    { 8, "index", true, "PictureAsset", "Picture Assets", 1 },
                    { 9, "index", true, "VideoAssets", "Video Assets", 1 },
                    { 10, "index", true, "Executive", "Executives", 1 },
                    { 11, "Index", true, "About", "About", 1 },
                    { 12, "Index", true, "Menu", "Setup Menu", 1 },
                    { 13, "Index", true, "Permissions", "Unit Admin", 1 },
                    { 14, "Index", true, "DropDown", "Setup Drop Down", 1 }
                });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "Id", "About", "BackGroundImageUrl", "CanHaveMembers", "DateCreated", "Description", "Name", "NeedsConfirmation", "Unit_TypeId" },
                values: new object[,]
                {
                    { 1, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2430), null, "Umuota", false, 1 },
                    { 2, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2432), null, "Mmakwum", false, 1 },
                    { 3, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2434), null, "Uruowulu", false, 1 },
                    { 4, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2435), null, "Ugamuma", false, 1 },
                    { 5, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2437), null, "Ire", false, 1 },
                    { 6, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2438), null, "Lagos", false, 5 },
                    { 7, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2439), null, "Abuja", false, 5 },
                    { 8, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2440), null, "Port Harcourt", false, 5 },
                    { 9, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2442), null, "Aba", false, 5 },
                    { 10, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2443), null, "Abakaliki", false, 5 },
                    { 11, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2446), null, "Awka", false, 5 },
                    { 12, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2447), null, "Benin City", false, 5 },
                    { 13, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2448), null, "Enugu", false, 5 },
                    { 14, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2449), null, "Jos", false, 5 },
                    { 15, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2451), null, "Kaduna", false, 5 },
                    { 16, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2452), null, "Makurdi", false, 5 },
                    { 17, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2453), null, "Nnewi", false, 5 },
                    { 18, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2454), null, "Suleja", false, 5 },
                    { 19, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2456), null, "Warri", false, 5 },
                    { 20, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2457), null, "Umuota", false, 5 },
                    { 21, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2459), null, "Mmakwum", false, 5 },
                    { 22, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2461), null, "Uruowulu", false, 5 },
                    { 23, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2463), null, "Ugamuma", false, 5 },
                    { 24, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2464), null, "Ire", false, 5 },
                    { 25, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2465), null, "OWA UK", false, 5 },
                    { 26, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2466), null, "ODA USA", false, 5 },
                    { 27, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2469), null, "ODU South Africa", false, 5 },
                    { 28, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2471), null, "ODU Brazil", false, 5 },
                    { 29, "", "", false, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2473), null, "ODU Kuwait", false, 5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "Email", "FirstName", "GenderId", "IsActive", "IsSuspended", "LastName", "OtherName", "PassportUrl", "Password", "PhoneNumber", "RoleId" },
                values: new object[] { 1L, new DateTime(2024, 4, 6, 9, 10, 49, 176, DateTimeKind.Local).AddTicks(2272), "Admin@obosi.ng", "", 1, true, false, "", null, null, "1234567", "070", 1 });

            migrationBuilder.InsertData(
                table: "MenuInRole",
                columns: new[] { "Id", "MenuId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 8, 1 },
                    { 9, 9, 1 },
                    { 10, 10, 1 },
                    { 11, 11, 1 },
                    { 12, 12, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aka_UnitId",
                table: "Aka",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Aka_VillageId",
                table: "Aka",
                column: "VillageId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Comment_BlogsId",
                table: "Blogs_Comment",
                column: "BlogsId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Comment_UserId",
                table: "Blogs_Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Update_BlogsId",
                table: "Blogs_Update",
                column: "BlogsId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Update_UserId",
                table: "Blogs_Update",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Calender_Assets_UnitId",
                table: "Calender_Assets",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Executive_UnitId",
                table: "Executive",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Executive_UserId",
                table: "Executive",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Imenne_UmunnaId",
                table: "Imenne",
                column: "UmunnaId");

            migrationBuilder.CreateIndex(
                name: "IX_Imenne_UnitId",
                table: "Imenne",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_Unit_UnitId",
                table: "Member_Unit",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_Unit_UsersId",
                table: "Member_Unit",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_MenuGroupId",
                table: "Menu",
                column: "MenuGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuInRole_MenuId",
                table: "MenuInRole",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuInRole_RoleId",
                table: "MenuInRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_News_UserId",
                table: "News",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_Comment_NewsId",
                table: "News_Comment",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_News_Comment_UserId",
                table: "News_Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_Update_NewsId",
                table: "News_Update",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_News_Update_UserId",
                table: "News_Update",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Personality_UserId",
                table: "Personality",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_Assets_UnitId",
                table: "Picture_Assets",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Reasons_For_Suspension_UsersId",
                table: "Reasons_For_Suspension",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Umunna_AkaId",
                table: "Umunna",
                column: "AkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Umunna_UnitId",
                table: "Umunna",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_Unit_TypeId",
                table: "Unit",
                column: "Unit_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitAdmin_UnitId",
                table: "UnitAdmin",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitAdmin_UsersId",
                table: "UnitAdmin",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                table: "Users",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_Assets_UnitId",
                table: "Video_Assets",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Village_UnitId",
                table: "Village",
                column: "UnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Blogs_Comment");

            migrationBuilder.DropTable(
                name: "Blogs_Update");

            migrationBuilder.DropTable(
                name: "Builders_Boulevard");

            migrationBuilder.DropTable(
                name: "Calender_Assets");

            migrationBuilder.DropTable(
                name: "Executive");

            migrationBuilder.DropTable(
                name: "Imenne");

            migrationBuilder.DropTable(
                name: "Member_Unit");

            migrationBuilder.DropTable(
                name: "MenuInRole");

            migrationBuilder.DropTable(
                name: "News_Comment");

            migrationBuilder.DropTable(
                name: "News_Update");

            migrationBuilder.DropTable(
                name: "Personality");

            migrationBuilder.DropTable(
                name: "Picture_Assets");

            migrationBuilder.DropTable(
                name: "Reasons_For_Suspension");

            migrationBuilder.DropTable(
                name: "UnitAdmin");

            migrationBuilder.DropTable(
                name: "Video_Assets");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Umunna");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Aka");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Village");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Unit_Type");
        }
    }
}
