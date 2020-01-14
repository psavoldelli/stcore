using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stcore.business;
using stcore.model;

namespace stcore.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {

        private readonly ILogger<IngredientController> Logger;
        
        private readonly IngredientService Ingredient;
        
        public IngredientController(ILogger<IngredientController> logger, IngredientService ingredient)
        {
            Logger = logger;
            Ingredient = ingredient;
        }

        [HttpGet]
        public IEnumerable<IngredientModel> List()
        {
            return Ingredient.List();
        }

        [HttpGet("{id}")]
        public IngredientModel Get(string id)
        {
            return Ingredient.Get(id);
        }

        [HttpPost]
        public IngredientModel Save(IngredientModel ingredient)
        {
            return Ingredient.Save(ingredient);
        }

        
        [HttpDelete]
        public bool Delete(string id)
        {
            return Ingredient.Delete(id);
        }
    }
}
