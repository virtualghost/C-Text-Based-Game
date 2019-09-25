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
        public Dictionary<string, BaseItem> Items { get; set; } = new Dictionary<string, BaseItem>();

        public void AddItem(string ItemName, BaseItem item)
        {
            Items.Add(ItemName, item);
        }
        
    }
}
