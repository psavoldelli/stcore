using System;
using System.Collections.Generic;
using LiteDB;
using stcore.business.Base;
using stcore.model;
using stcore.repository;
using stcore.repository.Base;

namespace stcore.business
{
    public class EquipmentService : BaseService<EquipmentModel>
    {
        public EquipmentService(BaseRepository<EquipmentModel> entity) : base(entity)
        {
            
        }
    }
}
