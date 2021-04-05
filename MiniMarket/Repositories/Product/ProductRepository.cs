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
    }
}