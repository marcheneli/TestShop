using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Domain.Entities;
using TestShop.Domain.Interfaces.Repositories;

namespace TestShop.DAL.ADO.Repositories
{
    public class ADOProductRepository : IProductRepository
    {
        IDbConnection connection;

        public ADOProductRepository(IDbConnection connection)
        {
            this.connection = connection;
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Product product) { }

        public void Update(Product product) { }

        public void Delete(Product product) { }
    }
}
