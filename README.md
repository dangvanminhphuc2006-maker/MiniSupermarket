# 🛒 DỰ ÁN HỆ THỐNG POS THU NGÂN & QUẢN LÝ KHO CLEAN HOUSE

## 👤 THÔNG TIN SINH VIÊN BÁO CÁO
* **Họ và tên:** Đặng Văn Minh Phúc
* **Mã sinh viên:** (bổ sung MSSV của bạn)
* **Lớp học phần:** CCQ2411D
* **Học kỳ:** Học kỳ 1 - Năm học 2026-2027

---

## 📅 BÁO CÁO CHI TIẾT - BUỔI 3: TÍCH HỢP SQL SERVER VÀ ENTITY FRAMEWORK CORE CODE-FIRST

### 1. MỤC TIÊU VÀ BỐI CẢNH THỰC TẾ
* **Mục tiêu:** 
  * Thay thế hoàn toàn cơ chế lưu tạm trên RAM (In-Memory) ở Buổi 1 và Buổi 2 bằng hệ quản trị cơ sở dữ liệu quan hệ **Microsoft SQL Server**.
  * Làm chủ kỹ thuật **Entity Framework Core (EF Core) Code-First**: Định nghĩa cấu trúc lớp C# (Entities) trước rồi tự động sinh cấu trúc bảng tương ứng trong CSDL.
  * Nắm vững các công cụ dòng lệnh **EF Core Migrations** và tối ưu hiệu năng truy vấn dữ liệu bất đồng bộ bằng **LINQ (async/await)**.
* **Bối cảnh thực tế đồ án:** Khi nhân viên thu ngân thực hiện các thao tác thêm mới, sửa, hoặc xóa dữ liệu nhóm hàng (Category) và sản phẩm (Product) trên giao diện desktop WinForms, toàn bộ dữ liệu phải được lưu trữ vĩnh viễn trong CSDL `CleanHouseDB`. Khi tắt ứng dụng hoặc khởi động lại API, các bản ghi dữ liệu vẫn được đảm bảo toàn vẹn.

---

### 📂 2. CẤU TRÚC THƯ MỤC TOÀN CỤC CỦA DỰ ÁN
```text
CleanHouse_POS_DangVanMinhPhuc/
│
├── MiniSupermarket.API/          # Dự án Web API (Backend)
│   ├── Controllers/              
│   │   └── CategoriesController.cs # Xử lý API CRUD kết nối trực tiếp với DB (async/await)
│   ├── Data/                     
│   │   └── SupermarketDbContext.cs # Quản lý kết nối Database và các tập dữ liệu EF Core
│   ├── Migrations/               # Thư mục tự động sinh ra khi thực thi lệnh Migration quản lý DB
│   ├── Models/                   
│   │   ├── Category.cs           # Thực thể Nhóm hàng (Data Annotations & Quan hệ 1-N)
│   │   └── Product.cs            # Thực thể Sản phẩm (Cấu hình kiểu dữ liệu & Khóa ngoại)
│   ├── appsettings.json          # Cấu hình chuỗi kết nối LocalDB
│   └── Program.cs                # Đăng ký DbContext vào kiến trúc Dependency Injection (DI)
│
└── MiniSupermarket.WinForms/     # Dự án Windows Forms (Frontend Client)
    └── FormCategoryManagement.cs # Giao diện đồ họa tương tác và thực thi gọi API Client
```

---

### 🛠️ 3. NỘI DUNG CÁC BƯỚC ĐÃ THỰC HIỆN

#### Bước 1: Thiết lập thư viện nền tảng (NuGet Packages)
Đã cài đặt thành công 3 gói thư viện nền tảng dành cho dự án Backend (`MiniSupermarket.API`):
1. `Microsoft.EntityFrameworkCore.SqlServer` - Trình điều khiển giao tiếp hạ tầng SQL Server.
2. `Microsoft.EntityFrameworkCore.Tools` - Cung cấp bộ lệnh quản trị cơ sở dữ liệu trong PMC.
3. `Microsoft.EntityFrameworkCore.Design` - Hỗ trợ môi trường sinh mã tự động cấu trúc bảng CSDL.

#### Bước 2: Khai báo kết nối hệ thống phòng máy (`appsettings.json`)
Cấu hình mặc định dùng SQL Server LocalDB, không cần tài khoản `sa`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=CleanHouseDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

#### Bước 3: Đăng ký dịch vụ lõi (`Program.cs`)
Tiêm phụ thuộc cấu hình kết nối ứng dụng thông qua dịch vụ hệ thống:
```csharp
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SupermarketDbContext>(options =>
    options.UseSqlServer(connectionString));
```

#### Bước 4: Khởi tạo cơ sở dữ liệu
Khi chạy API lần đầu, `Program.cs` gọi `InitializeDatabaseAsync()`. API áp dụng EF Core migration để tạo cơ sở dữ liệu `CleanHouseDB`, nạp dữ liệu mẫu và tạo/cập nhật các stored procedure báo cáo. Cấu hình mặc định dùng SQL Server LocalDB; nếu dùng SQL Server instance khác, hãy cập nhật `ConnectionStrings:DefaultConnection` trong `appsettings.json`.

#### Bước 5: Viết bộ điều khiển API bất đồng bộ (`CategoriesController.cs`)
Xóa bỏ hoàn toàn lớp dữ liệu bộ nhớ tạm cứng thời gian trước. Chuyển đổi sang gọi dữ liệu qua thực thể `_context` bằng kỹ thuật xử lý đa luồng độc lập như `ToListAsync()`, `FindAsync(id)`, và `SaveChangesAsync()` để ứng dụng chạy mượt mà, tối ưu tài nguyên phần cứng.

---

### 🚀 4. HƯỚNG DẪN KHỞI CHẠY VÀ KIỂM THỬ DỰ ÁN

#### Bước 1: Khởi động và chạy phía Backend (Web API)
1. Cần Windows, .NET 8 runtime và SQL Server LocalDB. Máy phát triển hiện tại có .NET 10 SDK, .NET 8 runtime và công cụ LocalDB.
2. Nếu LocalDB chưa có instance `MSSQLLocalDB`, mở PowerShell và chạy `SqlLocalDB.exe create MSSQLLocalDB`, sau đó `SqlLocalDB.exe start MSSQLLocalDB`.
3. Mở solution bằng Visual Studio, đặt `MiniSupermarket.API` làm startup project và nhấn **F5**. Hoặc chạy `dotnet run --project MiniSupermarket.API --launch-profile http` từ thư mục gốc.
4. Mở `http://localhost:5000/swagger` và thử `GET /api/Categories`. API tự tạo/cập nhật schema và dữ liệu mẫu khi khởi động lần đầu.

#### Bước 2: Khởi động và chạy phía Frontend (WinForms Client)
1. Giữ API đang chạy tại `http://localhost:5000` (đây là địa chỉ đã cấu hình trong WinForms).
2. Chạy `MiniSupermarket.WinForms` trong Visual Studio (**Debug** ➔ **Start New Instance**) hoặc bằng lệnh `dotnet run --project MiniSupermarket.WinForms`.
3. Đăng nhập bằng tài khoản mẫu `admin01` / `123456`, sau đó thử các thao tác quản lý. Dữ liệu được lưu xuống LocalDB.


## Hoàn thiện các tiêu chí API (bổ sung)

- Solution chỉ đưa vào đúng hai project chính: `MiniSupermarket.API` và `MiniSupermarket.WinForms`.
- API tự áp dụng EF Core migrations khi khởi động (`Database.MigrateAsync`) và tạo/cập nhật ba stored procedure báo cáo qua `SupermarketDbContext.InitializeDatabaseAsync()`. Có thể xem định nghĩa trong `MiniSupermarket.API/Database/StoredProcedures.sql`.
- Swagger bật trong môi trường Development và có cấu hình Bearer JWT ở nút **Authorize**.
- CORS policy `DevelopmentClients` được đăng ký trong `Program.cs`. WinForms dùng `HttpClient`, vốn không bị trình duyệt áp dụng CORS, và tự gắn Bearer token sau đăng nhập.
- Các API quản trị người dùng/vai trò/báo cáo yêu cầu vai trò Admin; các API bán hàng yêu cầu Admin hoặc Cashier; API sản phẩm yêu cầu đăng nhập và các thao tác ghi yêu cầu Admin hoặc Warehouse.
- Tài khoản demo hiện được seed để chạy thử; cần đổi mật khẩu và khóa JWT trước khi triển khai thật.

### Chạy thử

1. Mở solution trong Visual Studio 2022 với .NET 8 SDK.
2. Kiểm tra `MiniSupermarket.API/appsettings.json`, chỉnh `ConnectionStrings:DefaultConnection` phù hợp SQL Server trên máy.
3. Đặt `MiniSupermarket.API` làm startup project, chạy API và mở `/swagger`.
4. Đăng nhập bằng tài khoản demo được seed; nhấn **Authorize** và dán JWT để kiểm tra API bảo mật.
5. Chạy `MiniSupermarket.WinForms`; kiểm tra `Services/ApiClientService.cs` có cùng URL/cổng với API.

> Đã kiểm tra build solution trên máy phát triển Windows với .NET 10 SDK và target .NET 8. LocalDB instance cần được tạo lần đầu theo hướng dẫn ở trên.
