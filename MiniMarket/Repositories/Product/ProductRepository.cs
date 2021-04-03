using System.Threading.Tasks;
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
            _db.Products.Add(model);
            return await _db.SaveChangesAsync();
        }
    }
}