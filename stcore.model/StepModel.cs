using stcore.model.Base;

namespace stcore.model
{
    public class StepModel : BaseModel
    {
        public string Label { get; set; }

        public MenuItemModel[] Items { get; set; }

        public EquipmentModel[] Equipments { get; set; }
    }
}