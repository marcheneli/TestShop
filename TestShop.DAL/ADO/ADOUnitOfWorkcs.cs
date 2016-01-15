using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Domain.Interfaces;
using TestShop.Domain.Interfaces.Repositories;

namespace TestShop.DAL.ADO
{
    public class ADOUnitOfWorkcs : IUnitOfWork
    {
        SqlConnection connection;

        public ADOUnitOfWorkcs(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public IProductRepository Products
        {
            get
            {
                return null;
            }
        }

        public ICustomerRepository Customers
        {
            get
            {
                return null;
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                return null;
            }
        }

        public void Save() { }

        public void Dispose() { }
    }
}
