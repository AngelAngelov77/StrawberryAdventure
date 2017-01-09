using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class NPC : BasicCharacter, INPC, IIdentifiable
    {
        //private int _id;
        private IList<ItemsDrop> itemsDropList;
        //private int _experience;

        public NPC(string name,
                   int hitPoint,
                   int attack,
                   int defense,
                   IList<ItemsDrop> itemsDrop)
        {
            Name = name;
            BasicHitPoints = hitPoint;
            BasicAttack = attack;
            BasicDefense = defense;
            itemsDropList = itemsDrop;
        }

        public IList<ItemsDrop> DroppingItems
        {
            get
            {
                return itemsDropList;
            }
        }

        public IList<BasicItem> ItemsDropped()
        {
            var result = new List<BasicItem>();
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
