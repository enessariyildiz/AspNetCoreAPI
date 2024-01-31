using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.Entity.Concrete;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EFRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EFRoomDal(Context context):base(context)
        {
            
        }
    }
}
