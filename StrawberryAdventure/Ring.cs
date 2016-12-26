namespace StrawberryAdventure
{
    public class Ring : BasicItem
    {
        public Ring(string name,
                    int attackSpeed,
                    int hitPoints,
                    int accuracy,
                    int evasion,
                    int experience) : base(name, BodyPositions.Rings, ItemType.Jewel, bonusAttackSpeed: attackSpeed, bonusHitPoints: hitPoints,
                                           bonusAccuracy: accuracy, bonusEvasion: evasion, experienceModifier: experience)
        {

        }
    }
}