using System;

namespace StrawberryAdventure
{
    class Inventory : IInventory
    {
        BasicItem[] _items;
        int _backpack = (int) ItemPositions.Backpack1 - 1;

        public Inventory()
        {
            _items = new BasicItem[(int)ItemPositions.Count];
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
                Unequip((ItemPositions)item.BodyPosition);
            };
            _items[(int)item.BodyPosition] = item;
        }

        public void EquipItem(BasicItem item, bool removeAlreadyEquippedItem)
        {
            if (_items[(int)item.BodyPosition] == null || removeAlreadyEquippedItem)
            {
                EquipItem(item);
            }
            else
            {
                if (_backpack < (int)ItemPositions.BackpackLast)
                {
                    _backpack++;
                    _items[_backpack] = item;
                }
            }
        }

        public BasicItem GetItem(ItemPositions position)
        {
            return _items[(int)position];
        }
        public void RemoveItem(ItemPositions position)
        {
            if (position >= ItemPositions.Backpack1)
            {
                for (int i = (int)position + 1; i <= (int) ItemPositions.BackpackLast; i++)
                {
                    _items[i - 1] = _items[i];
                    _backpack--;
                }
            }
            else
            {
                Unequip(position);
            }
        }

        public void Unequip(ItemPositions position)
        {
            if (position >= ItemPositions.Backpack1)
            {
                RemoveItem(position);
            }
            if (_backpack < (int) ItemPositions.BackpackLast)
            {
                _backpack++;
                _items[_backpack] = _items[(int)position];
            }
            _items[(int)position] = null;
        }

    }
}
