/*
 * Họ tên sinh viên: Đặng Văn Minh Phúc
 * Mã sinh viên: 2124110256
 * Lớp học phần: CCQ2411D
 * Mô tả: Lớp tĩnh quản lý HttpClient kết nối Web API, tự động gắn JWT Bearer Token
 */
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MiniSupermarket.WinForms.Services
{
    public static class ApiClientService
    {
        // Khởi tạo một phiên bản HttpClient dùng chung cho toàn ứng dụng
        private static readonly HttpClient _client = new HttpClient
        {
            // Đảm bảo số cổng Port trùng khớp với số Port đang chạy của Web API Backend
            BaseAddress = new Uri("http://localhost:5000/api/")
        };

        // Phương thức cập nhật Bearer Token sau khi đăng nhập thành công
        public static HttpClient Client
        {
            get
            {
                string token = SessionManager.JwtToken;
                string? currentToken = _client.DefaultRequestHeaders.Authorization?.Parameter;
                if (!string.Equals(token, currentToken, StringComparison.Ordinal))
                {
                    _client.DefaultRequestHeaders.Authorization = string.IsNullOrWhiteSpace(token)
                        ? null
                        : new AuthenticationHeaderValue("Bearer", token);
                }

                return _client;
            }
        }

        public static void AttachToken(string token)
        {
            SessionManager.JwtToken = token;
            _client.DefaultRequestHeaders.Authorization = string.IsNullOrWhiteSpace(token)
                ? null
                : new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
