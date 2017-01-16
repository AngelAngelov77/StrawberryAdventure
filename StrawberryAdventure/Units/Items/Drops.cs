using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrawberryAdventure;

namespace StrawberryAdventure.Units.Items
{
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
