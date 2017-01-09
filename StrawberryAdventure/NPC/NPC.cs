using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class NPC : BasicCharacter, INPC, IIdentifiable
    {
        private int _id;
        private List<ItemsDrop> _itemsDrop;
        private int _experience;

        public NPC(string name,
                   int hitPoint,
                   int attack,
                   int defense,
                   List<ItemsDrop> itemsDrop)
        {
            Name = name;
            BasicHitPoints = hitPoint;
            BasicAttack = attack;
            BasicDefense = defense;
            _itemsDrop = itemsDrop;
        }

 

        public List<ItemsDrop> DroppingItems
        {
            get
            {
                return _itemsDrop;
            }
        }

        public List<BasicItem> ItemsDropped()
        {
            List<BasicItem> result = new List<BasicItem>();
            foreach (var item in DroppingItems)
            {
                if (item.Dropped())
                {
                    result.Add(item.Item);
                }
            }
            return result;
        }
    }
}
