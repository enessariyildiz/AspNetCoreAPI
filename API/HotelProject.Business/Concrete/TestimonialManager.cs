using HotelProject.Business.Abstarct;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;

namespace HotelProject.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
           return _testimonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
           _testimonialDal.Insert(t);
        }

        public void TRemove(Testimonial t)
        {
           _testimonialDal.Remove(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }

}
