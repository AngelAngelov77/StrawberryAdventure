namespace StrawberryAdventure
{
    class Identifiable
    {
        private static int _id = 0;

        public static int GetID()
        {
            return _id++;
        }
    }
}
