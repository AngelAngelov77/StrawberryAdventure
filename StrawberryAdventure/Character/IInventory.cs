namespace StrawberryAdventure
{
    public interface IInventory
    {
        BasicItem[] Items { get; }

        BasicItem GetItem(ItemPositions position);
        void EquipItem(BasicItem item);
        void EquipItem(BasicItem item, bool removeAlreadyEquippedItem);
        void Unequip(ItemPositions  position);
        void RemoveItem(ItemPositions position);
    }
}