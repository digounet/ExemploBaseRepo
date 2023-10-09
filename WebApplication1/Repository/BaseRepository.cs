using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private static List<T> db;

        public BaseRepository()
        {
            if (db == null)
            {
                db = new List<T>();
            }
        }

        public List<T> GetAll()
        {
            return db;
        }

        public void Save(T entity)
        {
            entity.Id = Guid.NewGuid();
            db.Add(entity);
        }
    }
}
