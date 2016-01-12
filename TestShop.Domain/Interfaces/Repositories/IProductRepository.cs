using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Domain.Entities;

namespace TestShop.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Product Get(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
