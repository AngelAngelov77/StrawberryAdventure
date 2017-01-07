namespace StrawberryAdventure
{
    public interface IInventory
    {
        BasicItem[] Items { get; }

        BasicItem GetItem(Potion position);
        void EquipItem(BasicItem item);
        void EquipItem(BasicItem item, bool removeAlreadyEquippedItem);
        void Unequip(Potion position);
        void RemoveItem(BasicItem item, BodyPositions position = BodyPositions.Backpack);
    }
}