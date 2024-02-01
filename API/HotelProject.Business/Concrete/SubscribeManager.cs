using HotelProject.Business.Abstarct;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;

namespace HotelProject.Business.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public Subscribe TGetById(int id)
        {
            return _subscribeDal.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _subscribeDal.Insert(t);
        }

        public void TRemove(Subscribe t)
        {
            _subscribeDal.Remove(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribeDal.Update(t);
        }
    }
}
