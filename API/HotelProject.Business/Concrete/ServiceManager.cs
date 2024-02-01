using HotelProject.Business.Abstarct;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;

namespace HotelProject.Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _serviceDal;

        public ServiceManager(IServicesDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public Service TGetById(int id)
        {
           return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TInsert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TRemove(Service t)
        {
            _serviceDal.Remove(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
