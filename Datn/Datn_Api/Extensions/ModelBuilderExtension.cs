using Datn_Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rank>().HasData(
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9232"),
                Name = "Đồng",
                NecessaryPoints = 1000,
                Description = "Sành điệu",
            },
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9233"),
                Name = "Bạc",
                NecessaryPoints = 2000,
                Description = "Sành điệu",
            },
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9234"),
                Name = "Vàng",
                NecessaryPoints = 5000,
                Description = "Sành điệu",
            },
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9235"),
                Name = "Bạch kim",
                NecessaryPoints = 8000,
                Description = "Sành điệu",
            },
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"),
                Name = "Kim cương",
                NecessaryPoints = 12000,
                Description = "Sành điệu",
            });

            modelBuilder.Entity<Role>().HasData(
                new Role() { Name = "Admin", NormalizedName = "ADMIN", Id = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872") },
                new Role() { Name = "User", NormalizedName = "USER", Id = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873") }
            );

            modelBuilder.Entity<User>().HasData(
            new User()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                RankId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"),
                Gender = 0,
                DateOfBirth = new DateTime(2003, 10, 20),
                Address = "Hoa Thanh Quế",
                Point = 12000,
                Status = 0,
                UserName = "ThanhTung",
                Email = "thanhtung@gmail.com",
                PasswordHash = "Thanhtung@09",
                PhoneNumber = "0696969696",
            },
            new User()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                RankId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"),
                Gender = 1,
                DateOfBirth = new DateTime(2003, 11, 11),
                Address = "Hoa Thanh Quế",
                Point = 12000,
                Status = 0,
                UserName = "QuynhAnh",
                Email = "quynhanhvippro@gmail.com",
                PasswordHash = "Quynhanh@03",
                PhoneNumber = "0363636363",
            });

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole()
                {
                    UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                    RoleId = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872")
                },
                new UserRole()
                {
                    UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                    RoleId = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873")
                });

            modelBuilder.Entity<Post>().HasData(
            new Post()
            {
                Id = new Guid("486d827b-27a7-4232-85c8-a14396cf0f12"),
                UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                Content = "Kính gửi: Qúy khách hàng\r\n\r\nBeePool chân thành cám ơn Qúy khách đã tin tưởng và ủng hộ chúng tôi trong suốt thời gian qua. Với mục tiêu nâng cao chất lượng phục vụ và phát triển công tác chăm sóc khách hàng, chúng tôi cập nhật lại chính sách bảo hành cho các sản phẩm cơ bida được giao dịch qua sàn Thương mại điện tử BeePool như sau:\r\n\r\n1. KIỂM TRA HÀNG HÓA\r\n\r\nNgay khi nhận hàng, Qúy khách vui lòng QUAY VIDEO lại toàn bộ quá trình khui hàng (Lưu ý: Chúng tôi chỉ chấp nhận 01 video với nội dung liền lạc duy nhất, không chấp nhận chụp hình sản phẩm) cụ thể như sau:\r\n\r\nBước 1: Quay tem code vận chuyển hoặc mã vận đơn để đảm bảo hàng hóa nguyên seal\r\nBước 2: Quay chi tiết lấy sản phẩm ra từ hộp/ kiện hàng để đảm bảo quý khách nhận đúng hàng hóa mình đã mua\r\nBước 3: Quay cận cảnh lăn Cán cơ trên mặt bàn bida hoặc bề mặt bằng phẳng tương tự như mặt kính, mặt bàn phẳng (Không chấp nhận video lăn trên nền nhà)\r\nBước 4: Quay cận cảnh lăn Ngọn cơ trên mặt bàn bida hoặc bề mặt bằng phẳng tương tự như mặt kính, mặt bàn phẳng (Không chấp nhận video lăn trên nền nhà)\r\nBước 5: Ghép Cán Cơ và Ngọn Cơ thành một cây cơ hoàn chỉnh sau đó quay video trên mặt bàn bida hoặc bề mặt bằng phẳng tương tự như mặt kính, mặt bàn phẳng (Không chấp nhận video lăn trên nền nhà)\r\nLưu ý: Qúy khách làm theo đúng trình tự từ Bước 1 đến Bước 5, nếu sản phẩm không đạt bước nào Qúy khách vui lòng TỪ CHỐI NHẬN SẢN PHẨM và LIÊN HỆ NGAY với chúng tôi để được hỗ trợ, trong quá trình kiểm tra cơ quý khách vui lòng không làm dơ (bẩn) cả ngọn và cán (ví dụ như thoa lơ lên đầu cơ). Tham khảo video khui hàng bên dưới:\r\n\r\n\r\n\r\n2. BẢO HÀNH SẢN PHẨM\r\n\r\nChúng tôi áp dụng chính sách bảo hành chung cho tất cả các sản phẩm CƠ BIDA được giao dịch qua BeePool như sau:\r\n\r\nĐối với cán cơ: Bảo hành tất cả các lỗi liên quan đến phần Ren, Đít Cơ, Ring\r\nĐối với Ngọn: Tất cả các lỗi liên quan đến Phần Ren, Phíp\r\nThời gian bảo hành: Theo thông tin niêm yết trên từng sản phẩm\r\nLỗi cong vênh cán cơ, ngọn cơ: Chúng tôi chỉ hỗ trợ khắc phục miễn phí với những lỗi cong vênh nhỏ có thể khắc phục bằng các thiết bị có sẵn tại xưởng của chúng tôi.\r\n3. BẢO QUẢN SẢN PHẨM\r\n\r\nSau khi sử dụng cơ xong vệ sinh cơ bằng khăn và dụng cụ vệ sinh chuyên dụng sau đó bỏ vào bao đựng cơ. Tuyệt đối không sử dụng nước hoặc khăn ướt để lau cơ. Tránh môi trường nóng lạnh thường xuyên là nguyên nhân gây cong vênh.",
                Title = "Chính sách Kiểm tra hàng hóa và Bảo hành cho sản phẩm là Cơ Bida",
                Image = "Post1.jpg",
                CreateDate = new DateTime(2023, 09, 11),
                Description = "This entry was posted in BLOG, CHÍNH SÁCH BẢO HÀNH, Tin Tức Bida and tagged Chính sách bảo hành.",
                Status = 0,
            },
            new Post()
            {
                Id = new Guid("486d827b-27a7-4232-85c8-a14396cf0f13"),
                UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                Content = "Kính gửi: Qúy Khách Hàng\r\n\r\nVới nhu cầu ngày càng tăng cao của Qúy khách muốn mua bán trao đổi cơ bida (bi-a) qua sử dụng (cơ bida cũ, cơ bida lướt hoặc cơ bida USED) với các mục đích như:\r\n\r\nBán cơ cũ để thu lại tiền mặt\r\nBán cơ cũ để mua sản phẩm cơ mới\r\nBán cơ cũ để mua một sản phẩm là cơ qua sử dụng khác\r\nBán cơ cũ để mua phụ kiện bida\r\nVới tất cả các yêu cầu trên của Qúy khách, BeePool đều có thể hỗ trợ thông qua nền tảng giao dịch Online và đội ngũ kỹ thuật của chúng tôi. Nhằm giúp Qúy khách hiểu rõ hơn về chính sách giao dịch cơ bida qua sử dụng, chúng tôi đưa ra quy trình với các bước sau:\r\nBước 1: Xác định nhu cầu của Qúy khách\r\nTrong bước này, đội ngũ kỹ thuật của BeePool sẽ xác định rõ nhu cầu của Qúy khách:\r\n\r\nTrường hợp 1: Khách hàng muốn bán lại cơ cũ và thu tiền mặt\r\nTrường hợp 2: Khách hàng muốn bán lại cơ cũ và mua lại một sản phẩm khác của được niêm yết hoặc có trên hệ thống của BeePool\r\nTrong mỗi trường hợp Qúy khách lựa chọn sẽ có mức định giá sản phẩm khác nhau tùy vào nhu cầu.\r\n\r\nBước 2: Xác định chất lượng kỹ thuật sản phẩm\r\nTrong bước này, Qúy khách vui lòng cung cấp cho chúng tôi các thông tin sau:\r\n\r\nMã sản phẩm, thương hiệu\r\nBộ sản phẩm bao gồm những gì: Cán cơ, ngọn cơ, bộ bảo vệ ren, bộ chụp đầu cơ, bao đựng cơ và các phụ kiện đi kèm khác nếu có\r\nMô tả rõ những nhược điểm của cơ: Ví dụ vết trầy xước, cong vênh, lồi lõm của sản phẩm (Qúy khách lưu ý: Nếu như mô tả và thực tế khác nhau chúng tôi bắt buộc phải cập nhật lại giá trị định giá hoặc gửi trả lại cơ cho Qúy khách)\r\nQúy khách chụp hình/video gửi lại cho chúng tôi: gồm hình tổng thể, hình đít cơ (chuôi cơ), hình ren cơ, hình ngọn cơ và các chi tiết trầy xước, lồi lõm (nếu có)\r\n\r\n\r\n\r\n\r\nBước 3: Định giá sơ bộ sản phẩm\r\nCăn cứ vào các thông tin và hình ảnh, video mà Qúy khách gửi từ Bước 2, chúng tôi sẽ xác định giá trị tạm tính của sản phẩm và thông báo với Qúy khách để xem xét và lựa chọn. Nếu quý khách đồng ý chúng tôi sẽ chuyển sang Bước 4.\r\n\r\nBước 4: Nhận hàng và Kiểm tra lại\r\nTrong bước này, chúng tôi sẽ cung cấp cho Qúy khách địa chỉ hoặc chúng tôi tự lên bill vận chuyển, Qúy khách vui lòng đóng gói hàng hóa kỹ càng để đảm bảo an toàn trong quá trình vận chuyển.\r\n\r\nNgay khi nhận được sản phẩm, chúng tôi sẽ tiến hành QUAY VIDEO KHUI HÀNG để đảm bảo chúng tôi đã nhận được sản phẩm đúng như mô tả của quý khách và những phụ kiện đi kèm với sản phẩm.\r\n\r\n\r\n\r\n Post Views: 659\r\nBước 5: Thanh toán\r\nNgay sau khi hoàn thành kiểm tra cơ ở Bước 4, chúng tôi sẽ chuyển tiền lại cho Qúy khách bằng tiền mặt hoặc chuyển khoản trong vòng 01 đến 03 ngày làm việc.",
                Title = "Hướng dẫn Khách hàng Giao dịch cơ bida qua sử dụng (USED)",
                Image = "Post2.jpg",
                CreateDate = new DateTime(2023, 09, 11),
                Description = "This entry was posted in BLOG, Tin Tức Bida and tagged Hướng dẫn.",
                Status = 0,
            },
            new Post()
            {
                Id = new Guid("486d827b-27a7-4232-85c8-a14396cf0f14"),
                UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                Content = "Kính gửi: Qúy Khách Hàng\r\n\r\nHiện nay nhu cầu về bàn bida (bi-a) mua về giải trí hoặc kinh doanh đang tăng cao, lựa chọn bàn bida cũ (qua sử dụng) đang được rất nhiều khách hàng sử dụng để tiết kiệm chi phí ban đầu. Với phương án lựa chọn bàn qua sử dụng cũng tiềm ẩn một số rủi ro, hiện nay trên các mạng xã hội và các diễn đàn về bida lớn nhỏ có rất nhiều bài “phốt” nhà bán hàng Người bán hàng giao Bàn bida cũ không đúng thỏa thuận, sau đó nhà bán trốn tránh trách nhiệm bằng rất nhiều lý do. Điều này đang dấy lên sự lo ngại khi giao dịch Online nói chung và mua bán cơ bida nói riêng.\r\n\r\nTrong bài viết này, BeePool sẽ cung cấp cho quý khách các thông tin cần làm rõ khi giao dịch bàn bida cũ để đảm giao dịch an toàn và quý khách nhận được sản phẩm tương xứng với số tiền bỏ ra bằng các thông tin cần làm rõ về bàn bida như sau:\r\n\r\nThông số kỹ thuật của bàn bida bao gồm: kích thước bàn (chiều dài x rộng x cao), loại mặt đá sử dụng, loại cao su sử dụng, thành băng, chân bàn và các chi tiết kỹ thuật khác.\r\nTình trạng hiện tại của bàn: Qúy khách yêu cầu nhà bán cung cấp tình trạng của bàn chủ yếu là các vết trầy xước hoặc khuyết tật ngoại quan.\r\nPhụ kiện theo bàn: Qúy khách cần làm rõ phụ kiện theo bàn gồm tên sản phẩm, số lượng và tình trạng (thông thường bàn cũ sẽ đi kèm với phụ kiện cũ)\r\nBáo giá: Qúy khách cần làm rõ giá trị đơn hàng bao gồm: giá trị hàng hóa, phí vận chuyển, lắp đặt. Qúy khách lưu ý trong bước này để đảm bảo chi phí không phát sinh Qúy khách nên cung cấp điều kiện lắp đặt: ví dụ như có phải lên lầu, có hỗ trợ thang máy, có xuống hầm hay không để tránh phát sinh chi phí.\r\nPhương án thanh toán: Qúy khách nên thỏa thuận thật kỹ phương án thanh toán. Thông thường nhà bán hàng sẽ yêu cầu một khoản đặt cọc, sau đó lắp đặt bàn giao xong sẽ thanh toán phần còn lại.\r\nPhương án bảo hành: trước khi ký kết thỏa thuận, quý khách cần làm rõ điều kiện bảo hành bao gồm: thời gian bảo hành, phạm vi bảo hành và thời gian xử lý sự kiện bảo hành.\r\nKiểm tra hàng hóa trước khi lắp đặt: ngay khi hàng tới, quý khách nên yêu cầu được kiểm tra hàng hóa xem có đúng cam kết đã thỏa thuận hay không rồi mới quyết định cho lắp đặt. Để đảm bảo quyền lợi Qúy khách nên quay video hoặc chụp hình quá trình kiểm tra, nếu có thắc mắc yêu cầu nhà bán giải đáp.\r\nGiám sát quá trình lắp đặt: Qúy khách cần theo dõi giám sát quá trình lắp đặt để đảm bảo vật tư không bị hư hao, đồng thời bàn được đảm bảo trước khi nghiệm thu bàn giao.\r\nChúng tôi hi vọng với các thông tin trên, Qúy khách sẽ tìm được bàn bida cũ ưng ý và tận hưởng những giây phút giải trí riêng thật tuyệt vời.\r\n\r\nTrân trọng!",
                Title = "[GÓC CẢNH BÁO] Người bán hàng giao Bàn bida cũ không đúng thỏa thuận",
                Image = "Post3.jpg",
                CreateDate = new DateTime(2023, 09, 11),
                Description = "This entry was posted in BLOG, Tin Tức Bida. Bookmark the permalink.",
                Status = 0,
            });

            modelBuilder.Entity<Material>().HasData(
                new Material()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d81"),
                    Name = "Gỗ Phong già",
                    Status = 0,

                },
                new Material()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d71"),
                    Name = "Gỗ Phong Canada cao cấp",
                    Status = 0,

                });

            modelBuilder.Entity<Ren>().HasData(
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d82"),
                    Name = "5/16/18",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d72"),
                    Name = "5/16/14",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d62"),
                    Name = "3/8/11",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d52"),
                    Name = "3/8/10",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d42"),
                    Name = "United",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d32"),
                    Name = "Fury mini uniloc",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d22"),
                    Name = "Uniloc",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d12"),
                    Name = "True loc",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d02"),
                    Name = "Radial",
                    Status = 0,
                },
                new Ren()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d92"),
                    Name = "Wavy",
                    Status = 0,
                });

            modelBuilder.Entity<Handle>().HasData(
            new Handle()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                Name = "Cuốn chỉ",
                Status = 0,

            },
            new Handle()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                Name = "Bọc da",
                Status = 0,
            },
            new Handle()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                Name = "Bọc cao su",
                Status = 0,
            },
            new Handle()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                Name = "Trơn",
                Status = 0,
            });

            modelBuilder.Entity<Tip>().HasData(
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                Name = "F1 CLEAR",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                Name = "F1 france",
                Status = 0,
            });

            modelBuilder.Entity<Gripe>().HasData(
            new Gripe()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                Name = "CW4",
                Status = 0,
            },
            new Gripe()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                Name = "CW3",
                Status = 0,
            });
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    MaterialId = new Guid("cc37720a-7e89-463a-9510-1936e6761d81"),
                    RenId = new Guid("cc37720a-7e89-463a-9510-1936e6761d82"),
                    HandleId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    GripeId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Name = "Gậy bida sành điệu 1",
                    ImportPrice = 1000,
                    Price = 1500,
                    AvailableQuantity = 1000,
                    Sold = 500,
                    Image = "gay1.png",
                    CreateDate = new DateTime(2023, 09, 11),
                    Producer = "Lucasi",
                    Status = 0,
                    Description = "Description",
                },
                   new Product()
                   {
                       Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                       MaterialId = new Guid("cc37720a-7e89-463a-9510-1936e6761d81"),
                       RenId = new Guid("cc37720a-7e89-463a-9510-1936e6761d82"),
                       HandleId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                       TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                       GripeId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                       Name = "Gậy bida sành điệu 2",
                       ImportPrice = 1000,
                       Price = 1500,
                       AvailableQuantity = 1000,
                       Sold = 500,
                       Image = "gay2.png",
                       CreateDate = new DateTime(2023, 09, 11),
                       Producer = "Lucasi",

                       Status = 0,
                       Description = "Description",
                   },
                      new Product()
                      {
                          Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"),
                          MaterialId = new Guid("cc37720a-7e89-463a-9510-1936e6761d71"),
                          RenId = new Guid("cc37720a-7e89-463a-9510-1936e6761d72"),
                          HandleId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                          TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                          GripeId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                          Name = "Gậy bida sành điệu 3",
                          ImportPrice = 1000,
                          Price = 1500,
                          AvailableQuantity = 1000,
                          Sold = 500,
                          Image = "gay3.png",
                          CreateDate = new DateTime(2023, 09, 11),
                          Producer = "Molinari",
                          Status = 0,
                          Description = "Description",
                      });

            modelBuilder.Entity<Cart>().HasData(
                new Cart()
                {
                    UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                });

            modelBuilder.Entity<CartDetail>().HasData(
                new CartDetail()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d02"),
                    CartId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                    ProductId = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    Quantity = 1,
                    Price = 1500
                });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    Name = "BK",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d04"),
                    Name = "Cuetec",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d05"),
                    Name = "Demon",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d06"),
                    Name = "EXCEED",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d07"),
                    Name = "Fury",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d08"),
                    Name = "Peri Pool",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d09"),
                    Name = "Predator",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d00"),
                    Name = "HOW",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d10"),
                    Name = "Mezz",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d11"),
                    Name = "Mit",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d12"),
                    Name = "Cơ Lỗ Cho Người Mới",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d13"),
                    Name = "Rhino",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d14"),
                    Name = "The Rack",
                    Status = 0
                });

            modelBuilder.Entity<CategoryDetail>().HasData(
                new CategoryDetail()
                {
                    Id = new Guid("ff5bf36d-8272-4780-adbf-c4a717543079"),
                    CategoryId = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    ProductId = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    QuantityProduct = 2
                },
                new CategoryDetail()
                {
                    Id = new Guid("ff5bf36d-8272-4780-adbf-c4a717543078"),
                    CategoryId = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    ProductId = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    QuantityProduct = 2
                },
                new CategoryDetail()
                {
                    Id = new Guid("ff5bf36d-8272-4780-adbf-c4a717543077"),
                    CategoryId = new Guid("357267e8-d162-4844-a660-661f46933d04"),
                    ProductId = new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"),
                    QuantityProduct = 1
                });

            modelBuilder.Entity<BillStatus>().HasData(
            new BillStatus()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"),
                Name = "Đã xác nhận"
            },
            new BillStatus()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                Name = "Chờ xác nhận"
            });

            modelBuilder.Entity<Payment>().HasData(
            new Payment()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Name = "Offline",
            },
            new Payment()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"),
                Name = "Online",
            });

            modelBuilder.Entity<Voucher>().HasData(
            new Voucher()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf4"),
                Code = "DEMACIA",
                Value = 30,
                TimeStart = new DateTime(2023, 09, 11),
                TimeEnd = new DateTime(2023, 10, 11),
                Status = 0,
            },
            new Voucher()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14"),
                Code = "Pitover",
                Value = 50,
                TimeStart = new DateTime(2023, 09, 11),
                TimeEnd = new DateTime(2023, 09, 18),
                Status = 1,
            });

            modelBuilder.Entity<Bill>().HasData(
            new Bill()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"),
                UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                BillStatusId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                PaymentId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Price = 1500,
                CreateDate = new DateTime(2023, 09, 11),
                Address = "Bình nguyên vô tận",

            },
            new Bill()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"),
                UserId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                BillStatusId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"),
                PaymentId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"),
                Price = 1450,
                CreateDate = new DateTime(2023, 09, 11),
                Address = "phi phai",
            });

            modelBuilder.Entity<UsedVoucher>().HasData(
                new UsedVoucher()
                {
                    BillId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"),
                    VoucherId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14")
                });

            modelBuilder.Entity<BillDetail>().HasData(
            new BillDetail()
            {
                Id = new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e79"),
                BillId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"),
                ProductId = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                Quantity = 1,
                Price = 1500,
            },
            new BillDetail()
            {
                Id = new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e78"),
                BillId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"),
                ProductId = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                Quantity = 1,
                Price = 1450,
            });
        }
    }
}
