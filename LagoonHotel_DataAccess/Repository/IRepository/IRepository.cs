namespace LagoonHotel_DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Save();
    }
}
