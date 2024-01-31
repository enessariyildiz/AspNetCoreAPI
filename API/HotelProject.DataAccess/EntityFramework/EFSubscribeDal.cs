using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.Entity.Concrete;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EFSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EFSubscribeDal(Context context) : base(context)
        {
        }
    }
}
