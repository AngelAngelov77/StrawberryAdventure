using System.Collections.Generic;

namespace StrawberryAdventure
{
    public abstract class BasicCharacter : ICharacter, IIdentifiable
    {
        private int _id;
        private const int _skillPointsPerLevel = 5;
        public int BasicHitPoints { get; protected set; }
        public int BasicAttack { get; protected set; }
        public int BasicDefense { get; protected set; }
        public int BasicAccuracy { get; protected set; }
        public int BasicEvasion { get; protected set; }
        public int Level { get; protected set; }
        public IInventory MyInventory { get; protected set; }
        public int SkillPoints { get; protected set; }

        public string Name { get; protected set; }
        public List<BasicSkill> Skills { get; protected set; }

        public int Attack
        {
            get
            {
                int result = BasicAttack;
                foreach (var skill in Skills)
                {
                    result += skill.AttackBonus;
                }
                foreach (var item in MyInventory.Items)
                {
                    if (item.BodyPosition != BodyPositions.Backpack)
                    {
                        result += item.BonusAttack;
                    }
                }
                return result;
            }
        }

        public int Defense
        {
            get
            {
                int result = BasicDefense;
                foreach (var skill in Skills)
                {
                    result += skill.DefenseBonus;
                }
                foreach (var item in MyInventory.Items)
                {
                    if (item.BodyPosition != BodyPositions.Backpack)
                    {
                        result += item.BonusDefense;
                    }
                }
                return result;
            }
        }

        public int Accuracy
        {
            get
            {
                int result = BasicAccuracy;
                foreach (var skill in Skills)
                {
                    result += skill.AccuracyBonus;
                }
                foreach (var item in MyInventory.Items)
                {
                    if (item.BodyPosition != BodyPositions.Backpack)
                    {
                        result += item.BonusAccuracy;
                    }
                }
                return result;
            }
        }

        public int HitPoints
        {
            get
            {
                int result = BasicHitPoints;
                foreach (var skill in Skills)
                {
                    result += skill.HitPointsBonus;
                }
                foreach (var item in MyInventory.Items)
                {
                    if (item.BodyPosition != BodyPositions.Backpack)
                    {
                        result += item.BonusHitPoints;
                    }
                }
                return result;
            }
        }

        public int Evasion
        {
            get
            {
                int result = BasicEvasion;
                foreach (var skill in Skills)
                {
                    result += skill.EvasionBonus;
                }
                foreach (var item in MyInventory.Items)
                {
                    if (item.BodyPosition != BodyPositions.Backpack)
                    {
                        result += item.BonusEvasion;
                    }
                }
                return result;
            }
        }

        public int ChestUnlockSkill
        {
            get
            {
                int result = 0;
                foreach (var skill in Skills)
                {
                    if (skill.ChestUnlockLevel > 0 )
                    {
                        result = skill.ChestUnlockLevel;
                        break;
                    };
                }
                return result;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public void LevelUp()
        {
            SkillPoints += _skillPointsPerLevel;
        }

    }
}
