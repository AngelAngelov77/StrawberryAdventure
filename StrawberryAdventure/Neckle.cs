namespace StrawberryAdventure
{
    public class Neckle : BasicItem
    {
        public Neckle(string name,
                      int attackSpeed,
                      int hitPoints,
                      int accuracy,
                      int evasion,
                      int experience) : base(name, BodyPositions.Neck, ItemType.Jewel, bonusAttackSpeed: attackSpeed, bonusHitPoints: hitPoints,
                                           bonusAccuracy: accuracy, bonusEvasion: evasion, experienceModifier: experience)
        {

        }
    }
}