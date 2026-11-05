# Checklist 25 tiêu chí – CleanHouse POS

| STT | Tiêu chí | Tệp/điểm kiểm tra sau chỉnh sửa |
|---:|---|---|
| 1 | Connection string JSON | `MiniSupermarket.API/appsettings.json` |
| 2 | Controller và REST route | `Controllers/AuthController.cs`, `CategoriesController.cs`, `ProductsController.cs` |
| 3 | HTTP verbs/status codes | Các Controller dùng GET/POST/PUT/DELETE và Ok/CreatedAtAction/BadRequest/NotFound/NoContent |
| 4 | DTO | `Models/*Dto.cs`, DTO trong các Controller; một số API legacy vẫn cần chuẩn hóa DTO thêm nếu chấm theo yêu cầu không trả Entity ở mọi endpoint |
| 5 | async/await | EF Core Controller và Reports dùng async; một số endpoint ADO.NET legacy vẫn đồng bộ, cần build/test và chuẩn hóa thêm nếu giảng viên yêu cầu tuyệt đối mọi action async |
| 6 | Swagger UI | `Program.cs`, Swagger bật trong Development |
| 7 | 6 model User/Category/Product/Customer/Order/OrderDetail | `Models/User.cs`, `UserAccount.cs`, `Category.cs`, `Product.cs`, `Customer.cs`, `BusinessEntities.cs`; `UserAccount` vẫn là entity EF đang ánh xạ bảng Users để giữ migration hiện có |
| 8 | DbContext và quan hệ | `Data/SupermarketDbContext.cs`, migration InitialCreateDatabase |
| 9 | Validation Entity | `Category.cs`, `Product.cs` (Required/StringLength/Range), `Customer.cs` |
| 10 | EF Core Migrations | `Data/SupermarketDbContext.cs` gọi `Database.MigrateAsync()` |
| 11 | Seed Data | `OnModelCreating` trong `SupermarketDbContext.cs` (15 categories, 23 products cùng dữ liệu liên quan) |
| 12 | CRUD | `CategoriesController.cs`, `ProductsController.cs`, `CustomersController.cs` |
| 13 | LINQ search/filter | `ProductsController.cs`, `CategoriesController.cs` |
| 14 | Pagination | `ProductsController.cs` dùng Skip/Take |
| 15 | Include Category | `ProductsController.cs` dùng Include(p => p.Category) |
| 16 | AsNoTracking | GET/list truy vấn trong Controller |
| 17 | JWT login | `AuthController.cs`, `Program.cs` |
| 18 | Authorization | `[Authorize]` và `[Authorize(Roles=...)]` trên các Controller/endpoint cần bảo vệ |
| 19 | Role Admin/Cashier | Users/Roles/Reports chỉ Admin; checkout/orders Admin hoặc Cashier; quản lý sản phẩm Admin hoặc Warehouse |
| 20 | Swagger Authorize | Bearer JWT trong `Program.cs` |
| 21 | Barcode ADO.NET | `AdoProductController.cs` |
| 22 | SqlDataReader/parameterized SQL | `AdoProductController.cs`, `CheckoutController.cs`, `ReportsController.cs` |
| 23 | Stored Procedure | `Database/StoredProcedures.sql`; `InitializeDatabaseAsync()` tự CREATE OR ALTER ba thủ tục khi khởi động |
| 24 | Transaction/Rollback checkout | `CheckoutController.cs` dùng SqlTransaction và Rollback |
| 25 | Solution đúng 2 project + Program.cs/CORS | `CleanHouse_POS_DangVanMinhPhuc.sln` chỉ chứa API và WinForms; `MiniSupermarket.API/Program.cs` đăng ký Swagger/CORS/Auth |

## Lưu ý xác minh

Không thể xác nhận đạt 100% bằng cách chỉ đọc mã nguồn. Môi trường chỉnh sửa không có .NET SDK/SQL Server nên chưa chạy được build hoặc kiểm thử API thực tế. Đặc biệt, tiêu chí DTO và async tuyệt đối mọi action còn có một số endpoint cũ cần chuẩn hóa thêm nếu rubric chấm nghiêm ngặt. Trước khi nộp, mở solution bằng Visual Studio 2022 + .NET 8, kiểm tra connection string, chạy migration và test Swagger/WinForms.
