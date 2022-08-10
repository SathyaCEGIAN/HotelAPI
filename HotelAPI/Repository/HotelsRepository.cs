using HotelAPI.Contracts;
using HotelAPI.Data;

namespace HotelAPI.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelAPIDbContext context) : base(context)
        {
        }
    }
}
