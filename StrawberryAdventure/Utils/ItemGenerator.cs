using System.Collections.Generic;
using System.Linq;
namespace StrawberryAdventure
{
    public static class ItemGenerator
    {
        public static Armor GetArmor(string name)
        {
            List<Armor> armorList = new List<Armor> {
            new Armor("Basic", 3, 3),
            new Armor("Leaher", 2, 5),
            new Armor("Mail", 5, 2),
            new Armor("Silver", 5, 5),
            new Armor("Gold", 8, 8),
            new Armor("Platinium", 10, 10),
            new Armor("Diamond", 12, 12),
            new Armor("Challenger", 20, 20)
        };
            var armor = armorList
                        .Where(x => x.Name == name)
                        .ToList();
            return armor[0];
        }
        public static Boots GetBoots(string name)
        {
            List<Boots> bootsList = new List<Boots> {
            new Boots("Basic Boots", 3),
            new Boots("Leaher Boots", 2),
            new Boots("Mail Boots", 5),
            new Boots("Silver Boots", 5),
            new Boots("Gold Boots", 8),
            new Boots("Platinium Boots", 10),
            new Boots("Diamond Boots", 12),
            new Boots("Challenger Boots", 20)
        };
            var boots = bootsList
                        .Where(x => x.Name == name)
                        .ToList();
            return boots[0];
        }
        public static Gloves GetGloves(string name)
        {
            List<Gloves> glovesList = new List<Gloves> {
            new Gloves("Basic Gloves", 3),
            new Gloves("Leaher Gloves", 2),
            new Gloves("Mail Gloves", 5),
            new Gloves("Silver Gloves", 5),
            new Gloves("Gold Gloves", 8),
            new Gloves("Platinium Gloves", 10),
            new Gloves("Diamond Gloves", 12),
            new Gloves("Challenger Gloves", 20)
        };
            var gloves = glovesList
                        .Where(x => x.Name == name)
                        .ToList();
            return gloves[0];
        }
        public static Helmet GetHelmet(string name)
        {
            List<Helmet> helmetList = new List<Helmet> {
            new Helmet("Basic Helmet", 3, 3),
            new Helmet("Leaher Helmet", 2, 5),
            new Helmet("Mail Helmet", 5, 2),
            new Helmet("Silver Helmet", 5, 5),
            new Helmet("Gold Helmet", 8, 8),
            new Helmet("Platinium Helmet", 10, 10),
            new Helmet("Diamond Helmet", 12, 12),
            new Helmet("Challenger Helmet", 20, 20)
        };
            var helmet = helmetList
                        .Where(x => x.Name == name)
                        .ToList();
            return helmet[0];
        }
        public static Leggings GetLeggings(string name)
        {
            List<Leggings> leggingsList = new List<Leggings> {
            new Leggings("Basic Leggings", 3, 3),
            new Leggings("Leaher Leggings", 2, 5),
            new Leggings("Mail Leggings", 5, 2),
            new Leggings("Silver Leggings", 5, 5),
            new Leggings("Gold Leggings", 8, 8),
            new Leggings("Platinium Leggings", 10, 10),
            new Leggings("Diamond Leggings", 12, 12),
            new Leggings("Challenger Leggings", 20, 20)
        };
            var leggings = leggingsList
                        .Where(x => x.Name == name)
                        .ToList();
            return leggings[0];
        }
        public static Necklace GetNecklace(string name)
        {
            List<Necklace> necklaceList = new List<Necklace> {
            new Necklace("Basic Necklace", 3),
            new Necklace("Leaher Necklace", 5),
            new Necklace("Mail Necklace", 2),
            new Necklace("Silver Necklace", 5),
            new Necklace("Gold Necklace", 8),
            new Necklace("Platinium Necklace", 10),
            new Necklace("Diamond Necklace", 12),
            new Necklace("Challenger Necklace", 20)
        };
            var necklace = necklaceList
                        .Where(x => x.Name == name)
                        .ToList();
            return necklace[0];
        }
        public static Ring GetRing(string name)
        {
            List<Ring> ringList = new List<Ring> {
            new Ring("Basic Ring", 3),
            new Ring("Leaher Ring", 5),
            new Ring("Mail Ring", 2),
            new Ring("Silver Ring", 5),
            new Ring("Gold Ring", 8),
            new Ring("Platinium Ring", 10),
            new Ring("Diamond Ring", 12),
            new Ring("Challenger Ring", 20)
        };
            var ring = ringList
                        .Where(x => x.Name == name)
                        .ToList();
            return ring[0];
        }
        public static Weapon GetWeapon(string name)
        {
            List<Weapon> weaponList = new List<Weapon> {
            new Weapon("Basic Weapon", 3),
            new Weapon("Light Weapon", 2),
            new Weapon("Heavy Weapon", 5),
            new Weapon("Silver Weapon", 5),
            new Weapon("Gold Weapon", 8),
            new Weapon("Platinium Weapon", 10),
            new Weapon("Diamond Weapon", 12),
            new Weapon("Challenger Weapon", 20),
        };
            var weapon = weaponList
                        .Where(x => x.Name == name)
                        .ToList();
            return weapon[0];
        }
    }
}
