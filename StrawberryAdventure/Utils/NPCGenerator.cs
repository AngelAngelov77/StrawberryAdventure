
namespace StrawberryAdventure
{
    using System.Collections.Generic;
    using System.Linq;

    public static class NPCGenerator
    {
        public static void GenerateNPCs()
        { }
            //TODO:return NPC collection to be used in map
              public static NPC GetNPC(string name)
        {
            List<NPC> npcList = new List<NPC> {
            new NPC("Dog", 3, 3, 3),
            new NPC("Wolf", 2, 2, 2),
            new NPC("Goblin", 5, 5, 5),
            new NPC("Ogre", 5, 6, 6),
            new NPC("Thief", 8, 9, 9),
            new NPC("Crazy rabit", 10, 14, 14),
            new NPC("Bear", 12, 15, 15),
            new NPC("Dragon", 20, 21, 21),
        };
            var npc = npcList
                        .Where(x => x.Name == name)
                        .ToList();
            return npc[0];
        }
    } 
}
