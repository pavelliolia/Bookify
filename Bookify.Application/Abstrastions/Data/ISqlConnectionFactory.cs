using System.Data;

namespace Bookify.Application.Abstrastions.Data;

public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}