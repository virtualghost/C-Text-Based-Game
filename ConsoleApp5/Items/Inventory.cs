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
        public Dictionary<string, BaseItems> List { get; set; } = new Dictionary<string, string>();

        public void AddItem(BaseItems item)
        {
            List.Add
        }
        
    }
}
