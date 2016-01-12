using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Domain.Interfaces.Repositories;

namespace TestShop.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IOrderRepository Orders { get; }
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }

        void Save();
    }
}
