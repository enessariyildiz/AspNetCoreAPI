namespace HotelProject.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Remove(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
