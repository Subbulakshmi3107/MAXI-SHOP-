using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiShop.Domain.Model;


namespace MaxiShop.Domain.Contracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {

        Task UpdateAsync(Category category);

    }
}