using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MaxiShop.Domain.Contracts;
using MaxiShop.Domain.Model;
using MaxiShop.Domain.Models;
using MaxiShop.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace MaxiShop.Infrastructure.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _dbContext.product.Include(x=>x.Category).Include(x => x.Brand).AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetDetailsAsync(int id)
        {
            return await _dbContext.product.Include(x => x.Category).Include(x => x.Brand).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Product product)
        {
            _dbContext.Update(product);
            await _dbContext.SaveChangesAsync();
        }
    }   

   
    

   
}

