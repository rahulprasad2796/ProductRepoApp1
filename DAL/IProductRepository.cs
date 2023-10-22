using ProductRepoApp.Models;
using System.Linq;

namespace ProductRepoApp.DAL
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(int id, Product product);
        void Delete(int id);
    }
}
