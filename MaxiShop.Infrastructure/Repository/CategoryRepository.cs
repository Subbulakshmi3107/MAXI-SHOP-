using System.Threading.Tasks;

using MaxiShop.Domain.Contracts;
using MaxiShop.Domain.Model;
using MaxiShop.Infrastructure.DbContexts;

namespace MaxiShop.Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task UpdateAsync(Category category)
        {
            _dbContext.Update(category);
            await _dbContext.SaveChangesAsync();
        }
    }
}
