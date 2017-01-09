using System;

namespace StrawberryAdventure
{

    public static class Rnd
    {
        static Random rnd;
        static Rnd()
        {
            rnd = new Random();
        }

        public static int Random(int max)
        {
            return rnd.Next(max);
        }
    }
}
