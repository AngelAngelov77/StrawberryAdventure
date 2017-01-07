using System;

namespace StrawberryAdventure
{
    public class NPC : BasicCharacter, INPC, IIdentifiable
    {
        private BodyPositions _bodyPositions;
        private int _id;
        private ItemsDrop[] _itemsDrop;
        private int _experience;
        private string _name;
        private int _level;

        public NPC(string name,
                   int hitPoint,
                   int attack,
                   int defense,
                   int accuracy,
                   int evasion,
                   int criticalRate,
                   IInventory NPCInventory,
                   int experience,
                   ItemsDrop[] itemsDrop,
                   BodyPositions bodyPositions,
                   int level)
        {
            Name = name;
            BasicHitPoints = hitPoint;
            BasicAttack = attack;
            BasicDefense = defense;
            BasicAccuracy = accuracy;
            BasicEvasion = evasion;
            BasicCriticalRate = criticalRate;
            MyInventory = NPCInventory;
            _experience = experience;
            _itemsDrop = itemsDrop;
            Level = level;
            _id = Identifiable.GetID();
        }

 
        public int Experience
        {
            get
            {
                return _experience;
            }
        }

        public ItemsDrop[] DroppingItems
        {
            get
            {
                return _itemsDrop;
            }
        }

        public BodyPositions BodyPositions
        {
            get
            {
                return _bodyPositions;
            }
        }
    }
}