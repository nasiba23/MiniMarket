using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniMarket.Repositories.Product
{
    public interface IProductRepository
    {
        Task<int> Create(Models.Product model);
        List<Models.Product> GetAll();
        void Update(Models.Product product);
        void Delete(long id);
        List<Models.Product> GetByCategory(long id);
    }
}