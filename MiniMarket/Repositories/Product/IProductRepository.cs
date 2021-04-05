using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniMarket.Repositories.Product
{
    public interface IProductRepository
    {
        Task<int> Create(Models.Product model);
        List<Models.Product> GetAll();
    }
}