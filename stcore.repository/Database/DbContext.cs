using LiteDB;
using Microsoft.Extensions.Options;
using stcore.model;
using System;


namespace stcore.repository.Database
{
    public class DbContext
    {
        #region Private fields
        private readonly LiteDatabase Database;
        
        #endregion

        #region Entities declaration
        

        public LiteCollection<IngredientModel> Ingredients => Database.GetCollection<IngredientModel>(typeof(IngredientModel).Name);

        #endregion 

        #region C/Tor

        public DbContext(IOptions<DbOptions> configs)
        {
            try
            {
                var db = new LiteDatabase(configs.Value.Name);
                if (db != null)
                    Database = db;
            }
            catch (Exception ex)
            {
                throw new Exception("Can find or create LiteDb database.", ex);
            }
        }  
    
        #endregion

        #region Public method

        public LiteCollection<T> GetEntity<T>() 
        {
            return Database.GetCollection<T>(typeof(T).Name);
        }

        #endregion
    }
}