using HotelProject.Business.Abstarct;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;

namespace HotelProject.Business.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public Staff TGetById(int id)
        {
            return _staffDal.GetById(id);   
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void TRemove(Staff t)
        {
            _staffDal.Remove(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
