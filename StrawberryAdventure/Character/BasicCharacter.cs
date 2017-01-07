using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public abstract class BasicCharacter : ICharacter
    {
        private const int _skillPointsPerLevel = 5;
        public int BasicHitPoints { get; private set; }
        public int BasicAttack { get; protected set; }
        public int BasicDefense { get; protected set; }
        public int BasicAccuracy { get; protected set; }
        public int BasicEvasion { get; protected set; }
        public int BasicShieldDefenseRate { get; protected set; }
        public int BasicCriticalRate { get; protected set; }
        public int BasicMinimalDamage { get; protected set; }
        public int BasicMaximalDamage { get; protected set; }
        public int Level { get; protected set; }
        public ICharacterInventory Inventory { get; protected set; }
        public int SkillPoints { get; protected set; }

        public string Name { get; protected set; }
        public List<BasicSkill> Skills { get; protected set; }

        public int Attack
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Defense
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Accuracy
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int HitPoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Evasion
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ChestUnlockSkill
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ID
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void LevelUp()
        {
            SkillPoints += _skillPointsPerLevel;
        }
    }
}