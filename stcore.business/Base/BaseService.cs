using System.Collections.Generic;
using LiteDB;
using stcore.model.Base;
using stcore.repository.Base;

namespace stcore.business.Base
{
    public class BaseService<T> where T : BaseModel
    {
        public BaseRepository<T> Entity { get; set; }

        public BaseService(BaseRepository<T> entity)
        {
            Entity = entity;
        }

        public IEnumerable<T> List() 
        {
            return Entity.List();
        }

        public T Get(string id) 
        {
            return Entity.Get(id);
        }

        public bool Delete(string id)
        {
            return Entity.Delete(id);
        }

        public T Save(T record)
        {            
            if(record.Id == null) {
                record.Id = ObjectId.NewObjectId().ToString();
            }

            Entity.Save(record);

            return record;
        }

    }
}