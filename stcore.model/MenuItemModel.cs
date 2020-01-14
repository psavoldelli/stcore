using stcore.model.Base;

namespace stcore.model
{
    public class MenuItemModel : BaseModel
    {
        public int Amount { get; set; }

        public IngredientModel Ingredient { get; set; }
    }
}