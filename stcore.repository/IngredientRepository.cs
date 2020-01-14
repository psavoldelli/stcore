using System;
using stcore.repository.Database;
using LiteDB;
using stcore.model;
using System.Collections.Generic;

namespace stcore.repository
{
    public class IngredientRepository
    {
        public DbContext Context { get; set; }

        public IngredientRepository( DbContext context ) 
        {
            Context = context;
        }

        public IEnumerable<IngredientModel> List() 
        {
            return Context.Ingredients.Find(
                Query.All()
            );
        }

        public bool Save(IngredientModel ingredient)
        {
            return Context.Ingredients.Upsert(ingredient);
        }
    }
}
