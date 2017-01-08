namespace StrawberryAdventure
{
    public class Ring : BasicItem
    {
        public Ring(string name,
                    int hitPoints,
                    int accuracy,
                    int evasion,
                    int experience) : base(name, BodyPositions.Fingers,
                                           ItemType.Jewel,
                                           bonusHitPoints: hitPoints,
                                           bonusAccuracy: accuracy,
                                           bonusEvasion: evasion, 
                                           experienceModifier: experience)
        {

        }
    }
}
