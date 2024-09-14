using RabbitMqProductAPI.Models;

namespace RabbitMqProductAPI.Services
{
    public interface IProductService
    {
        public Task< IEnumerable<Product>> GetProductListAsync();
        public Task <Product> GetProductByIdAsync(int id);
        public Task<Product> AddProductAsync(Product product);
        public Task <Product> UpdateProductAsync(Product product);
        public Task<bool> DeleteProductAsync(int Id);
    }
}
