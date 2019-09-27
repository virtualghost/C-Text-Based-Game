using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Items.CrystalTheory
{
    class BaseItemStat
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public BaseItem ABaseItem { get; set; }
        public Stat AStat { get; set; }
    }
}
