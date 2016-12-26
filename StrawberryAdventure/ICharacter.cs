using System.Collections.Generic;

namespace StrawberryAdventure
{
    public abstract class BasicCharacter
    {
        public int BasicHitPoints { get; private set; }
        public int BasicAttack { get; protected set; }
        public int BasicDefense { get; protected set; }
        public int BasicAccuracy { get; protected set; }
        public int BasicAttackSpeed { get; protected set; }
        public int BasicEvasion { get; protected set; }
        public int BasicShieldDefenseRate { get; protected set; }
        public int BasicCriticalRate { get; protected set; }
        public int BasicCriticalDamageModifier { get; protected set; }
        public int BasicMinimalDamage { get; protected set; }
        public int BasicMaximalDamage { get; protected set; }
        public int Level { get; protected set; }
        public ICharacterInventory Inventory { get; protected set; }

        public string Name { get; protected set; }
        public List<BasicSkills> Skills { get; protected set; }
    }
}