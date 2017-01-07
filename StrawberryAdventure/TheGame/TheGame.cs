using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public sealed class TheGame
    {
        private static volatile TheGame instance;
        private static object syncRoot = new Object();
        Map[] _maps;

        private TheGame() {}

        //Singelton
        public static TheGame GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new TheGame();
                    }
                }

                return instance;
            }
        }

        public Map[] Maps
        {
            get
            {
                return _maps;
            }
        }

        public Character Hero
        {
            get
            {
                throw new System.NotImplementedException();
            }

        }

        private static void DamageCalculator()
        {
            throw new System.NotImplementedException();
        }
    }
}