using Serilog;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormChiTieu
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var logsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            if (!Directory.Exists(logsDirectory))
            {
                Directory.CreateDirectory(logsDirectory);
            }

            // Cấu hình Serilog ghi file theo ngày vào thư mục Logs cạnh file .exe
            // RollingInterval.Day với tên log-.txt sẽ tạo file log-yyyyMMdd.txt
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(
                    path: Path.Combine(logsDirectory, "log-.txt"),
                    rollingInterval: RollingInterval.Day,
                    encoding: System.Text.Encoding.UTF8,
                    flushToDiskInterval: TimeSpan.FromSeconds(1),
                    shared: true,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();

            try
            {
                Log.Information("Ứng dụng Sổ chi tiêu cá nhân khởi động.");
                ApplicationConfiguration.Initialize();
                Application.Run(new FormChiTieu());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Ứng dụng gặp lỗi ngoài dự kiến và phải dừng: {Message}", ex.Message);
                MessageBox.Show($"Đã xảy ra lỗi nghiêm trọng: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Log.Information("Ứng dụng kết thúc.");
                Log.CloseAndFlush();
            }
        }
    }
}