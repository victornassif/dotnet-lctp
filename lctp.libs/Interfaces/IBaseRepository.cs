namespace lctp.libs.Interfaces
{
    public interface IBaseRepository<T> : IRepository
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        bool Delete(int id);
        bool Delete(T obj);
        T Update(T obj);
        IEnumerable<T> UpdateMany(IEnumerable<T> obj);
        T Create(T obj);
    }
}
