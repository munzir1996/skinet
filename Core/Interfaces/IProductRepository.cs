using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> getProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> getProductsAsync();
        Task<IReadOnlyList<ProductBrand>> getProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> getProductTypesAsync();

    }
}
