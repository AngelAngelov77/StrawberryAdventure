namespace StrawberryAdventure
{
    public class ItemsDrop
    {
        private BasicItem item;
        private int dropChance;

        public ItemsDrop(BasicItem item, int dropChance)
        {
            this.Item = item;
            this.DropChance = dropChance;
        }
        
        public BasicItem Item
        {
            get
            {
                return item;
            }

            private set
            {
                item = value;
            }
        }

        public int DropChance
        {
            get
            {
                return dropChance;
            }

            private set
            {
                this.dropChance = value;
            }
        }

        public bool Dropped()
        {
            return RandomGenerator.Random(100) < this.DropChance;
        }
    }
}
