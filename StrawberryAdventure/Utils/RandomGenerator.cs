using System;

namespace StrawberryAdventure
{
    public static class RandomGenerator
    {
        static Random rnd;
        static RandomGenerator()
        {
            rnd = new Random();
        }

        public static int Random(int max)
        {
            return rnd.Next(max);
        }
    }
}
