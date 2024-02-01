namespace HotelProject.Business.Abstarct
{
    public interface IGenericService<T> where T : class 
    {
        void TInsert(T t);
        void TRemove(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);
    }
}
