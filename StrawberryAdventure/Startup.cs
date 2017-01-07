using System;

namespace StrawberryAdventure
{
    public class Startup
    {
        public static void Main()
        {
            // TODO: Start game engine

            TheGame StrawberryAdventute = TheGame.GetInstance;

            Skill test = new Skill("Kroshe", level: 7, attackBonusBasic: 10, attackBonusPerLevel: 2);
            Console.WriteLine(test.ToString());
        }
    }
}
