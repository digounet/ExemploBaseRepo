using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Save(T entity);
        List<T> GetAll();
    }
}
