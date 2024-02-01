using HotelProject.Business.Abstarct;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;

namespace HotelProject.Business.Concrete
{
    internal class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TRemove(Room t)
        {
            _roomDal.Remove(t);
        }

        public void TUpdate(Room t)
        {
           _roomDal.Update(t);
        }
    }
}
