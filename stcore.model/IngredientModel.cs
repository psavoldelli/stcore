using stcore.model.Base;

namespace stcore.model
{
    public class IngredientModel : BaseModel
    {
        public string Name { get; set; }

        public string Unit { get; set; }

        public string Category { get; set; }

        public string Consitency { get; set; }

        public bool Gluten { get; set; }

        public bool Vegan  { get; set; }

        public bool Vegetarian  { get; set; }

        public bool Dairy { get; set; }
    }
}