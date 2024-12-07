using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiShop.Domain.Model;
using MaxiShop.Domain.Models;

namespace MaxiShop.Domain.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        Task<List<Product>> GetAllProductAsync();

        Task<Product> GetDetailsAsync(int id);
        Task UpdateAsync(Product product);
    }
}
