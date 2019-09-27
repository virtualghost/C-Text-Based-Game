using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Items.CrystalTheory
{
    class BaseItem
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public List<BaseItemStat> BaseItemStatList { get; set; } = new List<BaseItemStat>();

        public void SetStatValue(string Name, dynamic arg)
        {
            foreach (var looper in BaseItemStatList)
            {
                if (looper.AStat.Name.Equals(Name))
                    looper.MinValue = 0;
                    looper.MaxValue = arg;
            }
        }

    }
}
