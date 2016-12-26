using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public class Map
    {
        private StrawberryAdventure.MapObject[] _layout;
        private int _width;
        private int _height;
        private List<NPC> _monsters;
        private List<BasicItem> _items;
        private Character _strawberryHero;
        private string[] _itemPrefix = { "Wood", "Stone", "Iron", "Steel", "Mithril" };

        public Map(int width,
                   int height,
                   int obstruclesCount,
                   int monstersCount,
                   int chestsCount,
                   MapDificulty dificulty,
                   string heroName)
        {
            this.Width = width;
            this.Height = height;
            this.GenerateLayout(obstruclesCount, monstersCount, chestsCount, dificulty);
            this._strawberryHero = new Character(heroName);
        }

        public int Width
        {
            get
            {
                return _width;
            }

            private set
            {
                if (value > 20)
                {
                    _width = value;
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
                return _height;
            }

            private set
            {
                if (value > 20)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Map height should be no less than 20");
                }
            }
        }

        public MapObject[] Layout
        {
            get
            {
                return _layout;
            }
        }


        public NPC[] Monsters
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
            int chestsCount,
            MapDificulty dificulty)
        {
            
        }

        private void GenerateItems(MapDificulty dificulty)
        {
            for (int i = (int) MapDificulty.Newbie; i <= (int) dificulty; i++)
            {
                //_items.Add(new object());
            }
        }
    }
}