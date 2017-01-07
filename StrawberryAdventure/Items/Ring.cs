namespace StrawberryAdventure
{
    public class Ring : BasicItem
    {
        public Ring(string name,
                    int hitPoints,
                    int accuracy,
                    int evasion,
                    int experience) : base(name, BodyPositions.Rings,
                                           ItemType.Jewel,
                                           bonusHitPoints: hitPoints,
                                           bonusAccuracy: accuracy,
                                           bonusEvasion: evasion, 
                                           experienceModifier: experience)
        {

        }
    }
}