namespace StrawberryAdventure
{
    public class Necklace : BasicItem
    {
        public Necklace(string name,
                      int hitPoints,
                      int accuracy,
                      int evasion,
                      int experience) : base(name, BodyPositions.Neck,
                                             ItemType.Jewel,
                                             bonusHitPoints: hitPoints,
                                             bonusAccuracy: accuracy,
                                             bonusEvasion: evasion,
                                             experienceModifier: experience)
        {

        }
    }
}