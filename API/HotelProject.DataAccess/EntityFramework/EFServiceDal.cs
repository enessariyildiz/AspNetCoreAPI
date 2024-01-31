using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.Entity.Concrete;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EFServiceDal : GenericRepository<Service>, IServicesDal
    {
        public EFServiceDal(Context context) : base(context)
        {
        }
    }
}
