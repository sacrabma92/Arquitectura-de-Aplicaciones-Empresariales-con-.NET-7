using System;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Infraetructure.Interface;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using Pacagroup.Ecommerce.Transversal.Common;

namespace Pacagroup.Ecommerce.Infrastrucure.Repository
{
    internal class CustomersRepository : ICustomersRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public CustomersRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Metodos Sincronos

        public bool Insert(Customers customers)
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerID);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Address", customers.Address);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);

                var result = conection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Update(Customers customers)
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerID);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Address", customers.Address);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);

                var result = conection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Delete(string customerId)
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customerId);

                var result = conection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }

        }

        public Customers Get(string customerId)
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customerId);

                var customer = conection.QuerySingle<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;
            }

        }

        public IEnumerable<Customers> GetAll()
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";

                var customers = conection.Query<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;
            }

        }
        #endregion

        #region Metodos Asincronos
        public async Task<bool> InsertAsync(Customers customers)
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerID);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Address", customers.Address);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);

                var result = await conection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Customers customers)
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerID);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Address", customers.Address);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);

                var result = await conection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customerId);

                var result = await conection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }

        }

        public async Task<Customers> GetAsync(string customerId)
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customerId);

                var customer = await conection.QuerySingleAsync<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;
            }

        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            using (var conection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";

                var customers = await conection.QueryAsync<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;
            }

        }
        #endregion
    }
}
