using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public class MapGenerator
    {
        private static char[,] gameField;

        public MapGenerator()
        {
            gameField = new char[GlobalConstants.MapWidth, GlobalConstants.MapHeight];
        }

        public static void DrawMap()
        {
            for (int i = 0; i < GlobalConstants.MapHeight; i++)
            {
                // Starts from 1 because on ( 0;0 ) is the player
                for (int j = 1; j < GlobalConstants.MapWidth; j++)
                {
                    Console.Write(gameField[i, j]);
                }
            }
        }

        private static void GenerateMap()
        {
            for (int i = 0; i < GlobalConstants.MapHeight; i++)
            {
                    ArrangeLineCharacters(gameField, i);
            }
        }

        private static void ArrangeLineCharacters(char[,] gameField, int row)
        {
            // TODO: NPCs can be named with indexes ( 1,2,3 )
            // Example: ---------1-------*--
            // * is a chest
            var npcIndex = RandomGenerator.Random(GlobalConstants.MapWidth);

            for (int i = 0; i < GlobalConstants.MapWidth; i++)
            {
                // Some algorithm for chest position....Also not on every row is there an NPC so something must be done
                if (i == npcIndex)
                {
                    gameField[row, i] = (char)i;
                }
                else
                {
                    gameField[row, i] = GlobalConstants.MapTexture;
                }
            }
        }
    }
}
