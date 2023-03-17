using Shop.Infrastructure.Repository.Base;

namespace Shop.Infrastructure.Repository
{
    public interface IProductRepository : IRepository<EntitiesDB.ProductDB>
    {
        Task<IEnumerable<EntitiesDB.ProductDB>> GetProduct(int id);
    }
}
