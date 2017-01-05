using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrawberryAdventure
{
    class Startup
    {
        static void Main()
        {
            TheGame StrawberryAdventute = TheGame.GetInstance;

            Skill test = new Skill("Kroshe", level: 7, attackBonusBasic: 10, attackBonusPerLevel: 2);
            Console.WriteLine(test.ToString());
        }
    }
}
