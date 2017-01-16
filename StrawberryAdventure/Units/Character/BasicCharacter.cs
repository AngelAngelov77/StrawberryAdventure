using System;

namespace StrawberryAdventure
{
    public abstract class BasicCharacter : ICharacter, IIdentifiable
    {
        private int _id;

        public int BasicHitPoints { get; protected set; }

        public int BasicAttack { get; protected set; }

        public int BasicDefense { get; protected set; }

        public int Level { get; protected set; }

        public string Name { get; protected set; }


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
        public int HitPoints
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
                return _id;
            }
        }

        public BasicCharacter(string name,int hitPoints, int attack, int defense)
        {
            this.Name = name;
            this.BasicHitPoints = hitPoints;
            this.BasicAttack = attack;
            this.BasicDefense = defense;
            this.Level = 0;
        }

        public void LevelUp()
        {
            throw new NotImplementedException();
        }

    }
}
