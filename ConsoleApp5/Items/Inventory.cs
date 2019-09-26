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
        public Dictionary<string, List<ItemsInitializers>> List { get; set; } = new Dictionary<string, List<ItemsInitializers>>();

        public void AddItem(string ItemName, List<ItemsInitializers> item)
        {
            List.Add(ItemName, item);
        }
        
    }
}
