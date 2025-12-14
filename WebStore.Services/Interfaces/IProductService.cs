using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductVm> GetProductByIdAsync(int id);
        Task<IEnumerable<ProductVm>> GetAllProductsAsync();
        Task AddOrUpdateProductAsync(AddOrUpdateProductVm productVm);
        Task DeleteProductAsync(int id);
    } 
}