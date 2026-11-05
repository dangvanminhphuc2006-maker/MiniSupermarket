CLEAN HOUSE - HỆ THỐNG POS THU NGÂN VÀ QUẢN LÝ KHO
Đề tài: Thiết kế và Thi công Hệ thống POS Thu ngân tích hợp Quản lý Kho hàng – Cửa hàng Hóa phẩm Tẩy rửa Clean House
Môn học: Lập trình Ứng dụng .NET Core
Sinh viên: Đặng Văn Minh Phúc

1. Mục tiêu
Xây dựng hệ thống quản lý bán hàng cho cửa hàng hóa phẩm tẩy rửa Clean House, gồm Backend ASP.NET Core Web API và Client Windows Forms. Hệ thống hỗ trợ quản lý danh mục, sản phẩm, khách hàng, bán hàng/POS, hóa đơn và tồn kho.

2. Công nghệ
C# / .NET 8.0
ASP.NET Core Web API
Entity Framework Core Code-First
SQL Server
JWT Authentication và phân quyền
Windows Forms
Swagger UI
3. Chức năng chính
Đăng nhập và phân quyền Admin, Cashier, Warehouse.
Quản lý danh mục hóa phẩm tẩy rửa.
Quản lý sản phẩm: mã vạch, tên, đơn vị, giá bán, giá vốn, tồn kho.
Quản lý khách hàng và điểm tích lũy.
POS bán hàng và quản lý hóa đơn.
Theo dõi chi tiết hóa đơn.
Theo dõi nhập/xuất/điều chỉnh tồn kho.
Quản lý nhà cung cấp và chương trình khuyến mãi.
4. Kiến trúc
Clean House
├── MiniSupermarket.API        # ASP.NET Core Web API - Backend
├── MiniSupermarket.WinForms   # Windows Forms - Client
└── FormLogin                  # Màn hình đăng nhập
Tên thư mục/project kỹ thuật của bài gốc được giữ nguyên để tránh làm hỏng các Project Reference; nội dung nghiệp vụ và dữ liệu mẫu đã được chuyển sang Clean House.

5. Cơ sở dữ liệu
Các nhóm dữ liệu chính gồm:

Users
Categories
Products
Customers
Orders
OrderDetails
InventoryLogs
Brands
Suppliers
Promotions
6. Tác giả
Họ tên sinh viên: Đặng Văn Minh Phúc

7. Tạo lại Migration sau khi đổi dữ liệu mẫu
Do dữ liệu seed ban đầu của bài cũ đã được chuyển sang Clean House, thư mục Migration cũ không được dùng lại. Trong Visual Studio 2022, mở Package Manager Console, chọn project MiniSupermarket.API làm Default Project rồi chạy:

Add-Migration CleanHouseInitial
Update-Database
Database sử dụng tên CleanHouseDB.

8. Tài khoản mẫu
Admin: admin / 123456
Thu ngân: cashier01 / 123456
Kho: warehouse01 / 123456
