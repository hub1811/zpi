using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(ApplicationDbContext context, IMapper mapper, ILogger<BaseService> logger)
            : base(logger)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductVm> GetProductByIdAsync(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                throw new KeyNotFoundException("Product not found");
            }

            return _mapper.Map<ProductVm>(product);
        }

        public async Task<IEnumerable<ProductVm>> GetAllProductsAsync()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();

            return _mapper.Map<IEnumerable<ProductVm>>(products);
        }

        public async Task AddOrUpdateProductAsync(AddOrUpdateProductVm productVm)
        {
            Product product;

            if (productVm.Id.HasValue)
            {
                product = await _context.Products
                    .FirstOrDefaultAsync(p => p.Id == productVm.Id.Value);

                if (product == null)
                {
                    throw new KeyNotFoundException("Product not found");
                }

                // Update existing product
                product.Name = productVm.Name;
                product.Description = productVm.Description;
                product.ImageBytes = productVm.ImageBytes;
                product.Price = productVm.Price;
                product.Weight = productVm.Weight;
                product.CategoryId = productVm.CategoryId;
                product.SupplierId = productVm.SupplierId;
            }
            else
            {
                // Add new product
                product = _mapper.Map<Product>(productVm);
                _context.Products.Add(product);
            }

            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                throw new KeyNotFoundException("Product not found");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}