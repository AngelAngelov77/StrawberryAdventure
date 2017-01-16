
namespace StrawberryAdventure.Units.Items
{
    using System.Collections.Generic;

    class Drops
    {
        private IList<BasicItem> itemDrops;
        public IList<BasicItem> ItemDrops { get; private set; }
        public Drops(IList<BasicItem> itemDrops)
        {
            this.ItemDrops = itemDrops;
        }
        List<BasicItem> antDrop = new List<BasicItem> {  };
    }
}
