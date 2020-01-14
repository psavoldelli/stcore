using System;
using System.Collections.Generic;
using LiteDB;
using stcore.business.Base;
using stcore.model;
using stcore.repository;
using stcore.repository.Base;

namespace stcore.business
{
    public class IngredientService : BaseService<IngredientModel>
    {
        public IngredientRepository Ingredients { get; set; }

        public IngredientService(IngredientRepository ingredients, BaseRepository<IngredientModel> entity) : base(entity)
        {
            Ingredients = ingredients;
        }
    }
}
