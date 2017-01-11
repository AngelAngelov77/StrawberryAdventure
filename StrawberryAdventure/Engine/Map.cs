using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class Map
    {
        private StrawberryAdventure.MapObject[,] _layout;
        private int width;
        private int height;
        private List<NPC> monsters;
        private List<BasicItem> items;
        private Character strawberryHero;
        private string[] itemPrefix = { "Wood", "Stone", "Iron", "Steel", "Mithril" };

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Map(MapObject[,] layout)
        {
            Width = layout.GetLength(0);
            Height = layout.GetLength(1);
            _layout = layout;
        }

        public Map(int width,
                   int height,
                   int obstruclesCount,
                   int monstersCount,
                   int chestsCount,
                   string heroName)
        {
            this.Width = width;
            this.Height = height;
            this.GenerateLayout(obstruclesCount, monstersCount, chestsCount);
            //this._strawberryHero = new Character();
        }

        public int Width
        {
            get
            {
                return width;
            }

            private set
            {
                if (value >= 20)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Map width should be no less than 20");
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            private set
            {
                if (value >= 20)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Map height should be no less than 20");
                }
            }
        }

        public MapObject[,] Layout
        {
            get
            {
                return _layout;
            }
        }

        public void SetLayout(MapObject[,] layout)
        {
            if (layout.GetLength(0) == Width && layout.GetLength(1) == Height)
            {
                _layout = layout;
            }
        }

        public INPC[] Monsters
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void GenerateLayout(int obstruclesCount,
            int monstersCount,
            int chestsCount)
        {
            
        }

        private void GenerateItems()
        {
            for (int i = 0; i <= 5; i++)
            {
                //_items.Add(new object());
            }
        }
    }
}