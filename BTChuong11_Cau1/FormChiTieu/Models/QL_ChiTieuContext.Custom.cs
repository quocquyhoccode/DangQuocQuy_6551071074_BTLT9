using FormChiTieu.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FormChiTieu.Models;

public partial class QL_ChiTieuContext
{
    public QL_ChiTieuContext()
        : base(CreateDefaultOptions())
    {
    }

    private static DbContextOptions<QL_ChiTieuContext> CreateDefaultOptions()
    {
        var connectionString = ConfigurationManager.GetConnectionString();
        var builder = new DbContextOptionsBuilder<QL_ChiTieuContext>();
        builder.UseSqlServer(connectionString);
        return builder.Options;
    }

    public static QL_ChiTieuContext CreateContext()
    {
        return new QL_ChiTieuContext();
    }
}
