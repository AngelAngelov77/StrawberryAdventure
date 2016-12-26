using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public interface IPotion
    {
        int TimeEffectDuration { get; set; }
        int TimeEfectPower { get; set; }
        int ImediateEffect { get; set; }

        void Use();
    }
}