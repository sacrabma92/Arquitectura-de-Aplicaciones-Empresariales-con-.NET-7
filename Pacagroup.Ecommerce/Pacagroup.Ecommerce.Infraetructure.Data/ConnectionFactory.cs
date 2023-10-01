using Pacagroup.Ecommerce.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Pacagroup.Ecommerce.Infraetructure.Data
{
    internal class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;

                sqlConnection.ConnectionString = _configuration.GetConnectionString("DefaultConnection");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }
}
