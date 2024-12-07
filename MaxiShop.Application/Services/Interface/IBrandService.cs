using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiShop.Application.DTO.Brand;
using MaxiShop.Application.DTO.Category;

namespace MaxiShop.Application.Services.Interface
{
    public interface IBrandService
    {
        Task<BrandDto> GetByIdAsync(int id);

        Task<IEnumerable<BrandDto>> GetAllAsync();

        Task<BrandDto> CreateAsync(CreateBrandDto createBrandDto);

        Task UpdateAsync(UpdateCategoryDto updateCategoryDto);

        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateBrandDto dto);
    }
}
