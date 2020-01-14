using stcore.model.Base;

namespace stcore.model
{
    public class EquipmentModel : BaseModel
    {
        public string Name { get; set; }

        public string Capacity { get; set; }

        public string Unit { get; set; }
    }
}