using System;

namespace StrawberryAdventure
{
    public enum GameAction
    {
        None = 0,
        Moving,
        ObstrackleHit,
        ChestFound,
        ChestUnlocked,
        ChestResistedUnlock,
        BattleStarted,
        BattleHit,
        BattleWon,
        ExperienceGained,
        BattleLost,
        ItemsGathered
    }
}
