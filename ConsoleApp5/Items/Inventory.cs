using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Items
{
    class Inventory
    {
        public Inventory()
        {

        }
        public string MyInventory { get; set; } = "My Inventory";
        public Dictionary<string, List<BaseItems>> Dictionary { get; set; } = new Dictionary<string, List<BaseItems>>();

        public void AddItem(string ItemName, BaseItems item)
        {
            if (!Dictionary.ContainsKey(ItemName))
			{
                Dictionary.Add(ItemName, new List<BaseItems>());
			}
            Dictionary[ItemName].Add(item);
        }
        
    }
}
