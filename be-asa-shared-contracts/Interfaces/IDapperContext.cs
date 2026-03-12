using System.Data;

namespace be_asa_shared_contracts.Interfaces
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
