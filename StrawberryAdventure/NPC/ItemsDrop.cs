namespace StrawberryAdventure
{
    public class ItemsDrop
    {
        BasicItem _item;
        int _probability;

        public ItemsDrop(BasicItem item, int probability)
        {
            Item = item;
            Probability = probability;
        }
        
        public BasicItem Item
        {
            get
            {
                return _item;
            }

            private set
            {
                _item = value;
            }
        }

        public int Probability
        {
            get
            {
                return _probability;
            }

            private set
            {
                _probability = value;
            }
        }

        public bool Dropped()
        {
            return Rnd.Random(100) < Probability;
        }
    }
}
