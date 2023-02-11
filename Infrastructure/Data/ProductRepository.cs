using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext context;

        public ProductRepository(StoreContext context)
        {
            this.context = context;
        }

        public async Task<Product> getProductByIdAsync(int id)
        {
            return await this.context.Products.Include(p => p.ProductType).Include(p => p.ProductBrand).
                FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Product>> getProductsAsync()
        {
            return await this.context.Products.Include(p => p.ProductType).Include(p => p.ProductBrand).ToListAsync();
        }

        public async Task<IReadOnlyList<ProductBrand>> getProductBrandsAsync()
        {
            return await this.context.ProductBrands.ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> getProductTypesAsync()
        {
            return await this.context.ProductTypes.ToListAsync();
        }
    }
}
