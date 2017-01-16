//namespace StrawberryAdventure
//{
//    public class LevelingModel
//    {
//        private int[] experineceToLevel;
//        private int maxLevel;

//        public LevelingModel(int maxLevel = 50, int expForLevel1 = 1000, int percentageIncreasingExperience = 20)
//        {
//            this.maxLevel = maxLevel;
//            this.experineceToLevel = new int[maxLevel];
//            InitializeLevelingModel(maxLevel, expForLevel1, percentageIncreasingExperience);
//        }

//        private void InitializeLevelingModel(int maxLevel, int expForLevel1, int percentageIncreasingExperience)
//        {
//            for (int i = 0; i < maxLevel; i++)
//            {
//                experineceToLevel[i] = (int)(i * expForLevel1 * (1 + percentageIncreasingExperience / 100));
//            }
//        }

//        public int AddExperience(int currentExperience, int experienceGained, out bool levelUp)
//        {
//            levelUp = GetLevel(currentExperience + experienceGained) > GetLevel(currentExperience);
//            return currentExperience + experienceGained;
//        }

//        private int GetLevel(int experience)
//        {
//            int level;
//            for (level = 0; level < maxLevel && experineceToLevel[level] <= experience; level++)
//            {
//            }
//            return level;
//        }
//    }
//}
