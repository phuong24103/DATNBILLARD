using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn_Api.Migrations
{
    public partial class datn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gripes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gripes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Handles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NecessaryPoints = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Ranks_RankId",
                        column: x => x.RankId,
                        principalTable: "Ranks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HandleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GripeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    AvailableQuantity = table.Column<int>(type: "int", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Gripes_GripeId",
                        column: x => x.GripeId,
                        principalTable: "Gripes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Handles_HandleId",
                        column: x => x.HandleId,
                        principalTable: "Handles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Rens_RenId",
                        column: x => x.RenId,
                        principalTable: "Rens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Tips_TipId",
                        column: x => x.TipId,
                        principalTable: "Tips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_BillStatuses_BillStatusId",
                        column: x => x.BillStatusId,
                        principalTable: "BillStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuantityProduct = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriesDetail_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishLists_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsedVouchers",
                columns: table => new
                {
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedVouchers", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_UsedVouchers_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsedVouchers_Vouchers_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Vouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872"), "e94a71a5-dbd6-4771-860c-3cd9e00ebe3f", "Admin", "ADMIN" },
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873"), "a39a4a10-ed22-4fc4-9c02-cee3d9e66c38", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "BillStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"), "Chờ xác nhận" },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"), "Đã xác nhận" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("357267e8-d162-4844-a660-661f46933d00"), "HOW", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d03"), "BK", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d04"), "Cuetec", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d05"), "Demon", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d06"), "EXCEED", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d07"), "Fury", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d08"), "Peri Pool", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d09"), "Predator", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d10"), "Mezz", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d11"), "Mit", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d12"), "Cơ Lỗ Cho Người Mới", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d13"), "Rhino", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d14"), "The Rack", 0 }
                });

            migrationBuilder.InsertData(
                table: "Gripes",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d75"), "CW3", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d85"), "CW4", 0 }
                });

            migrationBuilder.InsertData(
                table: "Handles",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), "Trơn", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), "Bọc cao su", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), "Bọc da", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), "Cuốn chỉ", 0 }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d71"), "Gỗ Phong Canada cao cấp", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d81"), "Gỗ Phong già", 0 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"), "Online" },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"), "Offline" }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Description", "Name", "NecessaryPoints" },
                values: new object[,]
                {
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9232"), "Sành điệu", "Đồng", 1000 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9233"), "Sành điệu", "Bạc", 2000 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9234"), "Sành điệu", "Vàng", 5000 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9235"), "Sành điệu", "Bạch kim", 8000 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"), "Sành điệu", "Kim cương", 12000 }
                });

            migrationBuilder.InsertData(
                table: "Rens",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d02"), "Radial", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d12"), "True loc", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d22"), "Uniloc", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d32"), "Fury mini uniloc", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d42"), "United", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d52"), "3/8/10", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d62"), "3/8/11", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d72"), "5/16/14", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d82"), "5/16/18", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d92"), "Wavy", 0 }
                });

            migrationBuilder.InsertData(
                table: "Tips",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), "F1 france", 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), "F1 CLEAR", 0 }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "Id", "Code", "Status", "TimeEnd", "TimeStart", "Value" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14"), "Pitover", 1, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0 },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf4"), "DEMACIA", 0, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Point", "RankId", "RoleId", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), 0, "Hoa Thanh Quế", "db7d0357-d2ab-448a-80d6-2b474cba7179", new DateTime(2003, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "quynhanhvippro@gmail.com", false, 1, false, null, null, null, "Quynhanh@03", "0363636363", false, 12000, new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, false, "QuynhAnh" },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), 0, "Hoa Thanh Quế", "250a6f06-f531-4edb-98a9-f277a195eb31", new DateTime(2003, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhtung@gmail.com", false, 0, false, null, null, null, "Thanhtung@09", "0696969696", false, 12000, new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, false, "ThanhTung" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "CreateDate", "Description", "GripeId", "HandleId", "Image", "ImportPrice", "MaterialId", "Name", "Price", "Producer", "RenId", "Sold", "Status", "TipId" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1000, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", new Guid("cc37720a-7e89-463a-9510-1936e6761d85"), new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), "gay1.png", 1000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d81"), "Gậy bida sành điệu 1", 1500.0, "Lucasi", new Guid("cc37720a-7e89-463a-9510-1936e6761d82"), 500, 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84") },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1000, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", new Guid("cc37720a-7e89-463a-9510-1936e6761d85"), new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), "gay2.png", 1000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d81"), "Gậy bida sành điệu 2", 1500.0, "Lucasi", new Guid("cc37720a-7e89-463a-9510-1936e6761d82"), 500, 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84") },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"), 1000, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", new Guid("cc37720a-7e89-463a-9510-1936e6761d75"), new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), "gay3.png", 1000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d71"), "Gậy bida sành điệu 3", 1500.0, "Molinari", new Guid("cc37720a-7e89-463a-9510-1936e6761d72"), 500, 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873"), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), "UserRole" },
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872"), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), "UserRole" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "Address", "BillStatusId", "CreateDate", "PaymentId", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), "phi phai", new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"), 1450.0, new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230") },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"), "Bình nguyên vô tận", new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"), 1500.0, new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230") }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "UserId", "Description" },
                values: new object[] { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), null });

            migrationBuilder.InsertData(
                table: "CategoriesDetail",
                columns: new[] { "Id", "CategoryId", "ProductId", "QuantityProduct" },
                values: new object[,]
                {
                    { new Guid("ff5bf36d-8272-4780-adbf-c4a717543077"), new Guid("357267e8-d162-4844-a660-661f46933d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"), 1 },
                    { new Guid("ff5bf36d-8272-4780-adbf-c4a717543078"), new Guid("357267e8-d162-4844-a660-661f46933d03"), new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 2 },
                    { new Guid("ff5bf36d-8272-4780-adbf-c4a717543079"), new Guid("357267e8-d162-4844-a660-661f46933d03"), new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreateDate", "Description", "Image", "Status", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("486d827b-27a7-4232-85c8-a14396cf0f12"), "Kính gửi: Qúy khách hàng\r\n\r\nBeePool chân thành cám ơn Qúy khách đã tin tưởng và ủng hộ chúng tôi trong suốt thời gian qua. Với mục tiêu nâng cao chất lượng phục vụ và phát triển công tác chăm sóc khách hàng, chúng tôi cập nhật lại chính sách bảo hành cho các sản phẩm cơ bida được giao dịch qua sàn Thương mại điện tử BeePool như sau:\r\n\r\n1. KIỂM TRA HÀNG HÓA\r\n\r\nNgay khi nhận hàng, Qúy khách vui lòng QUAY VIDEO lại toàn bộ quá trình khui hàng (Lưu ý: Chúng tôi chỉ chấp nhận 01 video với nội dung liền lạc duy nhất, không chấp nhận chụp hình sản phẩm) cụ thể như sau:\r\n\r\nBước 1: Quay tem code vận chuyển hoặc mã vận đơn để đảm bảo hàng hóa nguyên seal\r\nBước 2: Quay chi tiết lấy sản phẩm ra từ hộp/ kiện hàng để đảm bảo quý khách nhận đúng hàng hóa mình đã mua\r\nBước 3: Quay cận cảnh lăn Cán cơ trên mặt bàn bida hoặc bề mặt bằng phẳng tương tự như mặt kính, mặt bàn phẳng (Không chấp nhận video lăn trên nền nhà)\r\nBước 4: Quay cận cảnh lăn Ngọn cơ trên mặt bàn bida hoặc bề mặt bằng phẳng tương tự như mặt kính, mặt bàn phẳng (Không chấp nhận video lăn trên nền nhà)\r\nBước 5: Ghép Cán Cơ và Ngọn Cơ thành một cây cơ hoàn chỉnh sau đó quay video trên mặt bàn bida hoặc bề mặt bằng phẳng tương tự như mặt kính, mặt bàn phẳng (Không chấp nhận video lăn trên nền nhà)\r\nLưu ý: Qúy khách làm theo đúng trình tự từ Bước 1 đến Bước 5, nếu sản phẩm không đạt bước nào Qúy khách vui lòng TỪ CHỐI NHẬN SẢN PHẨM và LIÊN HỆ NGAY với chúng tôi để được hỗ trợ, trong quá trình kiểm tra cơ quý khách vui lòng không làm dơ (bẩn) cả ngọn và cán (ví dụ như thoa lơ lên đầu cơ). Tham khảo video khui hàng bên dưới:\r\n\r\n\r\n\r\n2. BẢO HÀNH SẢN PHẨM\r\n\r\nChúng tôi áp dụng chính sách bảo hành chung cho tất cả các sản phẩm CƠ BIDA được giao dịch qua BeePool như sau:\r\n\r\nĐối với cán cơ: Bảo hành tất cả các lỗi liên quan đến phần Ren, Đít Cơ, Ring\r\nĐối với Ngọn: Tất cả các lỗi liên quan đến Phần Ren, Phíp\r\nThời gian bảo hành: Theo thông tin niêm yết trên từng sản phẩm\r\nLỗi cong vênh cán cơ, ngọn cơ: Chúng tôi chỉ hỗ trợ khắc phục miễn phí với những lỗi cong vênh nhỏ có thể khắc phục bằng các thiết bị có sẵn tại xưởng của chúng tôi.\r\n3. BẢO QUẢN SẢN PHẨM\r\n\r\nSau khi sử dụng cơ xong vệ sinh cơ bằng khăn và dụng cụ vệ sinh chuyên dụng sau đó bỏ vào bao đựng cơ. Tuyệt đối không sử dụng nước hoặc khăn ướt để lau cơ. Tránh môi trường nóng lạnh thường xuyên là nguyên nhân gây cong vênh.", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "This entry was posted in BLOG, CHÍNH SÁCH BẢO HÀNH, Tin Tức Bida and tagged Chính sách bảo hành.", "Post1.jpg", 0, "Chính sách Kiểm tra hàng hóa và Bảo hành cho sản phẩm là Cơ Bida", new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231") },
                    { new Guid("486d827b-27a7-4232-85c8-a14396cf0f13"), "Kính gửi: Qúy Khách Hàng\r\n\r\nVới nhu cầu ngày càng tăng cao của Qúy khách muốn mua bán trao đổi cơ bida (bi-a) qua sử dụng (cơ bida cũ, cơ bida lướt hoặc cơ bida USED) với các mục đích như:\r\n\r\nBán cơ cũ để thu lại tiền mặt\r\nBán cơ cũ để mua sản phẩm cơ mới\r\nBán cơ cũ để mua một sản phẩm là cơ qua sử dụng khác\r\nBán cơ cũ để mua phụ kiện bida\r\nVới tất cả các yêu cầu trên của Qúy khách, BeePool đều có thể hỗ trợ thông qua nền tảng giao dịch Online và đội ngũ kỹ thuật của chúng tôi. Nhằm giúp Qúy khách hiểu rõ hơn về chính sách giao dịch cơ bida qua sử dụng, chúng tôi đưa ra quy trình với các bước sau:\r\nBước 1: Xác định nhu cầu của Qúy khách\r\nTrong bước này, đội ngũ kỹ thuật của BeePool sẽ xác định rõ nhu cầu của Qúy khách:\r\n\r\nTrường hợp 1: Khách hàng muốn bán lại cơ cũ và thu tiền mặt\r\nTrường hợp 2: Khách hàng muốn bán lại cơ cũ và mua lại một sản phẩm khác của được niêm yết hoặc có trên hệ thống của BeePool\r\nTrong mỗi trường hợp Qúy khách lựa chọn sẽ có mức định giá sản phẩm khác nhau tùy vào nhu cầu.\r\n\r\nBước 2: Xác định chất lượng kỹ thuật sản phẩm\r\nTrong bước này, Qúy khách vui lòng cung cấp cho chúng tôi các thông tin sau:\r\n\r\nMã sản phẩm, thương hiệu\r\nBộ sản phẩm bao gồm những gì: Cán cơ, ngọn cơ, bộ bảo vệ ren, bộ chụp đầu cơ, bao đựng cơ và các phụ kiện đi kèm khác nếu có\r\nMô tả rõ những nhược điểm của cơ: Ví dụ vết trầy xước, cong vênh, lồi lõm của sản phẩm (Qúy khách lưu ý: Nếu như mô tả và thực tế khác nhau chúng tôi bắt buộc phải cập nhật lại giá trị định giá hoặc gửi trả lại cơ cho Qúy khách)\r\nQúy khách chụp hình/video gửi lại cho chúng tôi: gồm hình tổng thể, hình đít cơ (chuôi cơ), hình ren cơ, hình ngọn cơ và các chi tiết trầy xước, lồi lõm (nếu có)\r\n\r\n\r\n\r\n\r\nBước 3: Định giá sơ bộ sản phẩm\r\nCăn cứ vào các thông tin và hình ảnh, video mà Qúy khách gửi từ Bước 2, chúng tôi sẽ xác định giá trị tạm tính của sản phẩm và thông báo với Qúy khách để xem xét và lựa chọn. Nếu quý khách đồng ý chúng tôi sẽ chuyển sang Bước 4.\r\n\r\nBước 4: Nhận hàng và Kiểm tra lại\r\nTrong bước này, chúng tôi sẽ cung cấp cho Qúy khách địa chỉ hoặc chúng tôi tự lên bill vận chuyển, Qúy khách vui lòng đóng gói hàng hóa kỹ càng để đảm bảo an toàn trong quá trình vận chuyển.\r\n\r\nNgay khi nhận được sản phẩm, chúng tôi sẽ tiến hành QUAY VIDEO KHUI HÀNG để đảm bảo chúng tôi đã nhận được sản phẩm đúng như mô tả của quý khách và những phụ kiện đi kèm với sản phẩm.\r\n\r\n\r\n\r\n Post Views: 659\r\nBước 5: Thanh toán\r\nNgay sau khi hoàn thành kiểm tra cơ ở Bước 4, chúng tôi sẽ chuyển tiền lại cho Qúy khách bằng tiền mặt hoặc chuyển khoản trong vòng 01 đến 03 ngày làm việc.", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "This entry was posted in BLOG, Tin Tức Bida and tagged Hướng dẫn.", "Post2.jpg", 0, "Hướng dẫn Khách hàng Giao dịch cơ bida qua sử dụng (USED)", new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231") },
                    { new Guid("486d827b-27a7-4232-85c8-a14396cf0f14"), "Kính gửi: Qúy Khách Hàng\r\n\r\nHiện nay nhu cầu về bàn bida (bi-a) mua về giải trí hoặc kinh doanh đang tăng cao, lựa chọn bàn bida cũ (qua sử dụng) đang được rất nhiều khách hàng sử dụng để tiết kiệm chi phí ban đầu. Với phương án lựa chọn bàn qua sử dụng cũng tiềm ẩn một số rủi ro, hiện nay trên các mạng xã hội và các diễn đàn về bida lớn nhỏ có rất nhiều bài “phốt” nhà bán hàng Người bán hàng giao Bàn bida cũ không đúng thỏa thuận, sau đó nhà bán trốn tránh trách nhiệm bằng rất nhiều lý do. Điều này đang dấy lên sự lo ngại khi giao dịch Online nói chung và mua bán cơ bida nói riêng.\r\n\r\nTrong bài viết này, BeePool sẽ cung cấp cho quý khách các thông tin cần làm rõ khi giao dịch bàn bida cũ để đảm giao dịch an toàn và quý khách nhận được sản phẩm tương xứng với số tiền bỏ ra bằng các thông tin cần làm rõ về bàn bida như sau:\r\n\r\nThông số kỹ thuật của bàn bida bao gồm: kích thước bàn (chiều dài x rộng x cao), loại mặt đá sử dụng, loại cao su sử dụng, thành băng, chân bàn và các chi tiết kỹ thuật khác.\r\nTình trạng hiện tại của bàn: Qúy khách yêu cầu nhà bán cung cấp tình trạng của bàn chủ yếu là các vết trầy xước hoặc khuyết tật ngoại quan.\r\nPhụ kiện theo bàn: Qúy khách cần làm rõ phụ kiện theo bàn gồm tên sản phẩm, số lượng và tình trạng (thông thường bàn cũ sẽ đi kèm với phụ kiện cũ)\r\nBáo giá: Qúy khách cần làm rõ giá trị đơn hàng bao gồm: giá trị hàng hóa, phí vận chuyển, lắp đặt. Qúy khách lưu ý trong bước này để đảm bảo chi phí không phát sinh Qúy khách nên cung cấp điều kiện lắp đặt: ví dụ như có phải lên lầu, có hỗ trợ thang máy, có xuống hầm hay không để tránh phát sinh chi phí.\r\nPhương án thanh toán: Qúy khách nên thỏa thuận thật kỹ phương án thanh toán. Thông thường nhà bán hàng sẽ yêu cầu một khoản đặt cọc, sau đó lắp đặt bàn giao xong sẽ thanh toán phần còn lại.\r\nPhương án bảo hành: trước khi ký kết thỏa thuận, quý khách cần làm rõ điều kiện bảo hành bao gồm: thời gian bảo hành, phạm vi bảo hành và thời gian xử lý sự kiện bảo hành.\r\nKiểm tra hàng hóa trước khi lắp đặt: ngay khi hàng tới, quý khách nên yêu cầu được kiểm tra hàng hóa xem có đúng cam kết đã thỏa thuận hay không rồi mới quyết định cho lắp đặt. Để đảm bảo quyền lợi Qúy khách nên quay video hoặc chụp hình quá trình kiểm tra, nếu có thắc mắc yêu cầu nhà bán giải đáp.\r\nGiám sát quá trình lắp đặt: Qúy khách cần theo dõi giám sát quá trình lắp đặt để đảm bảo vật tư không bị hư hao, đồng thời bàn được đảm bảo trước khi nghiệm thu bàn giao.\r\nChúng tôi hi vọng với các thông tin trên, Qúy khách sẽ tìm được bàn bida cũ ưng ý và tận hưởng những giây phút giải trí riêng thật tuyệt vời.\r\n\r\nTrân trọng!", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "This entry was posted in BLOG, Tin Tức Bida. Bookmark the permalink.", "Post3.jpg", 0, "[GÓC CẢNH BÁO] Người bán hàng giao Bàn bida cũ không đúng thỏa thuận", new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231") }
                });

            migrationBuilder.InsertData(
                table: "BillDetails",
                columns: new[] { "Id", "BillId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e78"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), 1450.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1 },
                    { new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e79"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"), 1500.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1 }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "Id", "CartId", "Price", "ProductId", "Quantity" },
                values: new object[] { new Guid("357267e8-d162-4844-a660-661f46933d02"), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), 1500.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1 });

            migrationBuilder.InsertData(
                table: "UsedVouchers",
                columns: new[] { "BillId", "VoucherId" },
                values: new object[] { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RankId",
                table: "AspNetUsers",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_BillId",
                table: "BillDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ProductId",
                table: "BillDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillStatusId",
                table: "Bills",
                column: "BillStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PaymentId",
                table: "Bills",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserId",
                table: "Bills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartId",
                table: "CartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductId",
                table: "CartDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesDetail_CategoryId",
                table: "CategoriesDetail",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesDetail_ProductId",
                table: "CategoriesDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GripeId",
                table: "Products",
                column: "GripeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_HandleId",
                table: "Products",
                column: "HandleId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MaterialId",
                table: "Products",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RenId",
                table: "Products",
                column: "RenId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TipId",
                table: "Products",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_UsedVouchers_VoucherId",
                table: "UsedVouchers",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ProductId",
                table: "WishLists",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_UserId",
                table: "WishLists",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "CategoriesDetail");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "UsedVouchers");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BillStatuses");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Gripes");

            migrationBuilder.DropTable(
                name: "Handles");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Rens");

            migrationBuilder.DropTable(
                name: "Tips");

            migrationBuilder.DropTable(
                name: "Ranks");
        }
    }
}
