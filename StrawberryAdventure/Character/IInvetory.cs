namespace StrawberryAdventure
{
    public interface IInventory
    {
        BasicItem[] Items { get; }

        BasicItem GetItem(ItemPositions position);
        void EquipItem(BasicItem item);
        void RemoveItem(ItemPositions position);
    }
}
