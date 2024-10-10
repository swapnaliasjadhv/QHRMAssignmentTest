
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using QHRMAssiTest.Models;
using System.Data;
using System.Data.SqlClient;
namespace QHRMAssiTest.Repository
{
   

    public class ProductRepository
    {
        private readonly string _connectionString;
     
        public ProductRepository(IOptions<ConnectionStrings> config)
        {
            _connectionString = config.Value.myconn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Products";
                return connection.Query<Product>(sql);
            }
        }

        public void AddProduct(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Products (Name, Description, Price) VALUES (@Name, @Description, @Price)";
                connection.Execute(sql, product);
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price WHERE Id = @Id";
                connection.Execute(sql, product);
            }
        }

        public void DeleteProduct(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Products WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }

}
