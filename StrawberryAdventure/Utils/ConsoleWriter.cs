using System;

namespace StrawberryAdventure
{

    // Can be made also non static with Interface ( must be instantiated on every use )
    public static class ConsoleWriter
    {
        public static void Write(string text)
        {
            Console.Write(text);
        }

        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
