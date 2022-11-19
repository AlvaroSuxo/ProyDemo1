using ProyDemo1.Data.Entity;

namespace ProyDemo1.Data.Repository
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(DataContext context) : base(context)
        {

        }
    {
    }
}
