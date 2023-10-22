using ProductRepoApp.Models;
using System.Data.Entity;
using System.Linq;

namespace ProductRepoApp.DAL
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext _context = new ProductContext();

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(int id, Product product)
        {
            Product productToUpdate = GetById(id);

            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;

            _context.Entry(productToUpdate).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product productToDelete = GetById(id);

            _context.Products.Remove(productToDelete);
        }
    }
}