using stcore.model.Base;

namespace stcore.model
{
    public class RecipeModel : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public StepModel[] Steps { get; set; }
    }
}