namespace StrawberryAdventure
{
    public class Identifiable
    {
        private static int id = 0;

        public static int GetID()
        {
            return id++;
        }
    }
}
