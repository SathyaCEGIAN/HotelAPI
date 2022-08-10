using HotelAPI.Contracts;
using HotelAPI.Data;

namespace HotelAPI.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelAPIDbContext _context;
        public CountriesRepository(HotelAPIDbContext context) : base(context)
        {
            this._context = context;
        }

        public Task<Country> GetDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
