using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniMarket.Db;

namespace MiniMarket.Repositories.Product
{
    public class ProductRepository: IProductRepository
    {
        private DataContext _db;

        public ProductRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<int> Create(Models.Product model)
        {
            await _db.Products.AddAsync(model);
            return await _db.SaveChangesAsync();
        }

        public  List<Models.Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public void Update(Models.Product product)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
        }

        public void Delete(long id)
        {
            var product = _db.Products.FirstOrDefault(p=> p.Id == id);
            _db.Products.Remove(product);
            _db.SaveChanges();
        }

        public List<Models.Product> GetByCategory(long id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id)?.Products;
        }
    }
}