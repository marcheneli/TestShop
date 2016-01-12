using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
