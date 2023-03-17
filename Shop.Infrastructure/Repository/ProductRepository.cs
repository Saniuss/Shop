using Microsoft.EntityFrameworkCore;
using Shop.Infrastructure.EntitiesDB;

namespace Shop.Infrastructure.Repository
{
    public class ProductRepository : Base.Repository<ProductDB>, IProductRepository
    {
        public ProductRepository(Data.ShopContext appContext) : base(appContext)
        { }
        public async Task<IEnumerable<ProductDB>> GetProduct(int id)
        {
            return await _appContext.ProductDB.Where(x => x.Id == id).ToListAsync();
        }
    }
}
