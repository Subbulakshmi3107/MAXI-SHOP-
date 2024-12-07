using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiShop.Domain.Model;
using MaxiShop.Domain.Models;


namespace MaxiShop.Domain.Contracts
{
    public interface IBrandRepository : IGenericRepository<Brand>
    {

        Task UpdateAsync(Brand brand);

    }
}