using Core.Application.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Database.Implementations
{
    class Repository<T> : IRepository<T> where T : class
    {
        protected BookstoreDbContext context;
        public Repository(BookstoreDbContext context)
        {
            this.context = context;
        }


        public void Add(T entity)
        {

            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public bool Existed(int id)
        {
            var result = context.Set<T>().Find(id);
            if (result != null)
                return true;
            else
                return false;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);

        }
        public void Update(int id, T entity)
        {
            var existing = context.Set<T>().Find(id);
            context.Entry(existing).CurrentValues.SetValues(entity);
            context.SaveChanges();
        }
    }
}
