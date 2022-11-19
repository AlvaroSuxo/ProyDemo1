using ProyDemo1.Data.Entity;

namespace ProyDemo1.Data.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base (context)
        {

        }
    }
}
