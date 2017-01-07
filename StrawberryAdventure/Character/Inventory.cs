using System;

namespace StrawberryAdventure
{
    class Inventory : IInventory
    {
        BasicItem[] _items;

        public Inventory()
        {
            _items = new BasicItem[(int)ItemPositions.Count];
        }

        public BasicItem[] Items
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void EquipItem(BasicItem item)
        {
            throw new NotImplementedException();
        }

        public void EquipItem(BasicItem item, bool removeAlreadyEquippedItem)
        {
            throw new NotImplementedException();
        }

        public BasicItem GetItem(ItemPositions position)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(BasicItem item, BodyPositions position = BodyPositions.Backpack)
        {
            throw new NotImplementedException();
        }

        public void Unequip(ItemPositions position)
        {
            throw new NotImplementedException();
        }
    }
}
