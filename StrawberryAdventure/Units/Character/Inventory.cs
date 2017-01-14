
namespace StrawberryAdventure
{
    using System;

    class Inventory : IInventory
    {
        BasicItem[] _items;

        public Inventory()
        {
            var positionsCount = (int)ItemPositions.Count;
            _items = new BasicItem[positionsCount];
        }

        public BasicItem[] Items
        {
            get
            {
                return _items;
            }
        }

        public void EquipItem(BasicItem item)
        {
            if (_items[(int)item.BodyPosition] != null)
            {
                RemoveItem((ItemPositions)item.BodyPosition);
            };
            _items[(int)item.BodyPosition] = item;
        }

        public BasicItem GetItem(ItemPositions position)
        {
            return _items[(int)position];
        }
        public void RemoveItem(ItemPositions position)
        {
            throw new NotImplementedException();
        }
    }
}
