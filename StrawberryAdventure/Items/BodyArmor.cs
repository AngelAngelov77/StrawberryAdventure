namespace StrawberryAdventure
{
    public class BodyArmor : BasicItem
    {
        public BodyArmor(string name,
                         int defense,
                         int hitPoints,
                         int accuracy,
                         int evasion,
                         int experience) : base(name,
                                                BodyPositions.Body,
                                                ItemType.Armor,
                                                bonusDefense: defense,
                                                bonusHitPoints: hitPoints, 
                                                bonusAccuracy: accuracy,
                                                bonusEvasion: evasion,
                                                experienceModifier: experience)
        {

        }
    }
}