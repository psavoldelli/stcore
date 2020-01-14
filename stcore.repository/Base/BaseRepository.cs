using System.Linq;
using System.Collections.Generic;
using LiteDB;
using stcore.repository.Database;
using stcore.model.Base;

namespace stcore.repository.Base
{
    public class BaseRepository<T> where T : BaseModel 
    {
        public DbContext Context { get; set; }

        public BaseRepository(DbContext context)
        {
            Context = context;
        }

        public IEnumerable<T> List() 
        {
            return Context.GetEntity<T>().Find(
                Query.All()
            );
        }

        public T Get(string id) 
        {
            return Context.GetEntity<T>().FindById(id);
        }

        public bool Delete(string id)
        {
            return Context.GetEntity<T>().Delete(id);
        }

        public bool Save(T record)
        {            
            // upsert
            return Context.GetEntity<T>().Upsert(record);
        }
    }
}