using Datn_Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed (this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rank>().HasData(new Rank() {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"),
                Name = "Kim cương",
                NecessaryPoints= 10000,
                Description = "sành điệu ",
            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                RankId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"),
                Gender = 1,
                DateOfBirth = new DateTime(2003,11,11),
                Address = "Hoa Thanh Quế",
                Point = 10000,
               Status = 0,
               UserName = "QuynhAnh",
               NormalizedUserName = "QUYNHANH",
               Email = "quynhanhvippro@gmail.com",
               NormalizedEmail = "QUYNHANHVIPPRO@GMAIL.COM",
               EmailConfirmed = true,
               PasswordHash = "Quynhanh@03",
                //SecurityStamp = "Quynhanh@36",
                //ConcurrencyStamp = "Quynhanh@36",
                PhoneNumber = "0363636363",
                PhoneNumberConfirmed = true,
               // TwoFactorEnabled = true,
            });
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    MaterialId = new Guid("cc37720a-7e89-463a-9510-1936e6761d81"),
                    RenId = new Guid("cc37720a-7e89-463a-9510-1936e6761d82"),
                    HandleId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    TopId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    GripeId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Name = "Gậy bida sành điệu 1",
                    ImportPrice = 1000,
                    Price = 1500,
                    AvailableQuantity = 1000,
                    Sold = 500,
                    Image = "gay1.png",
                    CreateDate = DateTime.Now,
                    Producer = " Lucasi ",
                    Status = 0,
                    Description = "Description",
                },
                   new Product()
                   {
                       Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                       MaterialId = new Guid("cc37720a-7e89-463a-9510-1936e6761d81"),
                       RenId = new Guid("cc37720a-7e89-463a-9510-1936e6761d82"),
                       HandleId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                       TopId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                       GripeId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                       Name = "Gậy bida sành điệu 2",
                       ImportPrice = 1000,
                       Price = 1500,
                       AvailableQuantity = 1000,
                       Sold = 500,
                       Image = "gay2.png",
                       CreateDate = DateTime.Now,
                       Producer = " Lucasi ",
                       Status = 0,
                       Description = "Description",
                   },
                      new Product()
                      {
                          Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"),
                          MaterialId = new Guid("cc37720a-7e89-463a-9510-1936e6761d71"),
                          RenId = new Guid("cc37720a-7e89-463a-9510-1936e6761d72"),
                          HandleId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                          TopId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                          GripeId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                          Name = "Gậy bida sành điệu 3",
                          ImportPrice = 1000,
                          Price = 1500,
                          AvailableQuantity = 1000,
                          Sold = 500,
                          Image = "gay3.png",
                          CreateDate = DateTime.Now,
                          Producer = " Molinari  ",
                          Status = 0,
                          Description = "Description",
                      });
            modelBuilder.Entity<Material>().HasData(
                new Material()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d81"),
                    Name = " Carbon",
                    Status = 0,

                },
                    new Material()
                    {
                        Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d71"),
                        Name = " phủ carbon",
                        Status = 0,

                    });
            modelBuilder.Entity<Ren>().HasData(new Ren()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d82"),
                Name = "carbon",
                Status = 0,
            },
            new Ren()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d72"),
                Name = " bronze ",
                Status = 0,
            });
            modelBuilder.Entity<Handle>().HasData(new Handle()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                Name = "Họa tiết sành điệu",
                Status = 0,

            },
            new Handle()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                Name = " bọc da",
                Status= 0,
            });
            modelBuilder.Entity<Top>().HasData(new Top()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                Name = "Carbon họa tiết sành điệu",
                Status = 0,
            },
            new Top()
            {
                Id = new Guid ("cc37720a-7e89-463a-9510-1936e6761d74"),
                Name = "gỗ phủ carbon",
                Status = 0,
            });
            modelBuilder.Entity<Gripe>().HasData(new Gripe()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                Name = " Khảm",
                Status = 0,
            },
            new Gripe() {Id = new Guid ("cc37720a-7e89-463a-9510-1936e6761d75"),
            Name = "Ngọc",
            Status = 0,});
            modelBuilder.Entity<BillStatus>().HasData(new BillStatus()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"),
                Name = "đã thanh toán"
            },
          new BillStatus()
          {
              Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
              Name = "Chưa thanh toán"
          });
            modelBuilder.Entity<Payment>().HasData(new Payment()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Name = "Khi nhận hàng",
            },
            new Payment()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"),
                Name = "Online",
            });
            modelBuilder.Entity<Bill>().HasData(new Bill()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"),
                UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                //VoucherId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf4"),
                BillStatusId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"),
                PaymentId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Price = 1000,
                CreateDate = DateTime.Now,
                Address = "Bình nguyên vô tận",

            });
            /*new Bill()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"),
                UserId = new Guid("."),
                VoucherId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14"),
                BillStatusId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                PaymentId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"),
                Price = 1000,
                CreateDate = DateTime.Now,
                Address = "phi phai",
            });*/
            modelBuilder.Entity<Voucher>().HasData(new Voucher()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf4"),
                Code = "DEMACIA",
                Value = 3,
                TimeStart = DateTime.Today,
                TimeEnd = DateTime.Now,
                Status = 0,
            },
            new Voucher()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14"),
                Code = "Pitover",
                Value = 1,
                TimeEnd= DateTime.Today,
                TimeStart = DateTime.Today,
                Status = 0,
            });

            modelBuilder.Entity<BillDetail>().HasData(new BillDetail()
            {
                Id = new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e79"),
                BillId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"),
                ProductId = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                Quantity = 100,
                Price = 1500,
            });
      
          
        }

    }
}
