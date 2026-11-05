🛒 HỆ THỐNG QUẢN LÝ SIÊU THỊ MINI MINI SUPERMARKET SYSTEM Môn học: Lập trình Ứng dụng .NET Core Buổi thực hành: Buổi 2 - Xây dựng chức năng đăng nhập và phân quyền người dùng

📌 1. Giới thiệu Ở Buổi 2, dự án MiniSupermarket được phát triển thêm chức năng:

Đăng nhập hệ thống. Xác thực tài khoản thông qua Web API. Sinh và lưu JWT Token. Phân quyền người dùng theo Role. Kết nối ứng dụng WinForms với Web API. Hiển thị giao diện quản lý phù hợp với quyền đăng nhập. Hệ thống tiếp tục sử dụng mô hình Client - Server:

MiniSupermarket.API: Backend Web API. MiniSupermarket.WinForms: Ứng dụng Windows Forms Client. 🏗️ 2. Mô hình kiến trúc CLIENT - SERVER │ ┌────────────┴────────────┐ │ │ ▼ ▼ MiniSupermarket.WinForms MiniSupermarket.API (Client) (Server) │ │ │ HTTP Request │ ├────────────────────────►│ │ │ │ JSON Response │ │◄────────────────────────┤ │ │ ▼ ▼ WinForms Controllers Models JWT Role

🛠️ 3. Công nghệ sử dụng Backend C# ASP.NET Core Web API .NET 8.0 Controllers JWT Authentication Role Authorization In-Memory Data LINQ Frontend C# Windows Forms .NET 8.0 HttpClient System.Net.Http.Json System.Text.Json Công cụ Visual Studio 2022 Swagger UI Git / GitHub 📂 4. Cấu trúc Solution MiniSupermarketSystem/ │ ├── MiniSupermarket.API/ │ │ │ ├── Controllers/ │ │ ├── AuthController.cs │ │ ├── CategoriesController.cs │ │ └── RolesController.cs │ │ │ ├── Models/ │ │ ├── Category.cs │ │ └── Role.cs │ │ │ ├── Program.cs │ └── appsettings.json │ └── MiniSupermarket.WinForms/ │ ├── FormLogin.cs ├── FormLogin.Designer.cs ├── FormCategoryManagement.cs ├── FormRoleManagement.cs └── SessionManager.cs 🔐 5. Chức năng đăng nhập

Người dùng nhập:

Tài khoản Mật khẩu

WinForms gửi thông tin đăng nhập đến Web API bằng phương thức:

POST /api/auth/login

Dữ liệu gửi lên:

{ "Username": "admin", "Password": "123456" }

Nếu đăng nhập thành công, API trả về:

{ "token": "...", "role": "Admin" }

WinForms nhận dữ liệu và lưu:

SessionManager.JwtToken SessionManager.CurrentRole 🔑 6. JWT Token

Sau khi đăng nhập thành công, hệ thống nhận JWT Token từ Web API.

Token được lưu vào:

SessionManager.JwtToken

Token được sử dụng để xác thực người dùng khi thực hiện các chức năng yêu cầu đăng nhập.

👥 7. Phân quyền người dùng

Hệ thống sử dụng Role để xác định quyền của người dùng.

Ví dụ:

Admin User

Sau khi đăng nhập, hệ thống lấy Role từ API:

SessionManager.CurrentRole

Sau đó hiển thị thông báo:

Đăng nhập thành công với quyền: Admin 🖥️ 8. Giao diện WinForms FormLogin

Form đăng nhập gồm:

Ô nhập tài khoản. Ô nhập mật khẩu. Nút Đăng nhập.

Khi nhấn nút Đăng nhập:

FormLogin │ ▼ POST /api/auth/login │ ▼ Web API │ ▼ JWT Token + Role │ ▼ SessionManager FormCategoryManagement

Chức năng quản lý danh mục:

Hiển thị danh sách. Thêm danh mục. Sửa danh mục. Xóa danh mục. Tìm kiếm danh mục. FormRoleManagement

Chức năng quản lý quyền:

Hiển thị danh sách Role. Thêm Role. Sửa Role. Xóa Role. 🚀 9. Hướng dẫn chạy dự án Bước 1: Chạy Web API

Mở Solution bằng:

Visual Studio 2022

Chọn project:

MiniSupermarket.API

Chuột phải:

Set as Startup Project

Sau đó nhấn:

F5

Swagger UI sẽ được mở trên trình duyệt.

Bước 2: Kiểm tra API đăng nhập

Trong Swagger tìm:

POST /api/auth/login

Nhấn:

Try it out

Nhập tài khoản và mật khẩu.

Sau đó nhấn:

Execute

Kiểm tra kết quả trả về gồm:

token role Bước 3: Chạy WinForms

Chọn project:

MiniSupermarket.WinForms

Chuột phải:

Debug → Start new instance

Form Login sẽ xuất hiện.

Nhập:

Tài khoản Mật khẩu

Sau đó nhấn:

Đăng nhập hệ thống 🧪 10. Kiểm thử

Các chức năng được kiểm thử:

STT Chức năng Kết quả 1 Nhập tài khoản Thành công 2 Nhập mật khẩu Thành công 3 Đăng nhập đúng Thành công 4 Đăng nhập sai Hiển thị thông báo lỗi 5 Nhận JWT Token Thành công 6 Nhận Role Thành công 7 Mở Form quản lý Thành công 8 Quản lý danh mục Thành công 9 Quản lý Role Thành công 🌐 11. Kết nối API

WinForms sử dụng HttpClient để kết nối Web API.

Ví dụ:

private static readonly HttpClient _client = new HttpClient { BaseAddress = new Uri("https://localhost:7046/api/") };

API Login:

POST https://localhost:7046/api/auth/login 📌 12. Kết quả đạt được

Sau Buổi 2, hệ thống đã thực hiện được:

Xây dựng giao diện đăng nhập. Kết nối WinForms với Web API. Gửi thông tin tài khoản đến API. Xác thực tài khoản. Nhận JWT Token. Lưu thông tin phiên đăng nhập. Nhận và lưu Role người dùng. Phát triển chức năng phân quyền. Kết nối các chức năng quản lý với hệ thống đăng nhập. 👨‍💻 13. Thông tin sinh viên

Họ tên: Đặng Văn Minh Phúc

Mã sinh viên: 2124110264

Lớp học phần: CCQ2411C

Buổi thực hành: Buổi 1 Lớp học phần: CCQ2411C
