using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunShop.Core.Entities;
//using System.Collections.Generic;

namespace FunShop.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}