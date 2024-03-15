
using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces;
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProducts();
    Task<Product?> GetById(Guid? id);
    Task<Product> GetCategoryFromProductById(Guid? id);

    Task<Product> Create(Product product);
    Task<Product> Update(Product product);
    Task<Product> Remove(Product product);
}
