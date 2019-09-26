using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Items;
using TextGame.Items.InventoryItems;

namespace TextGame.Items
{
    static class ItemsInitializers
    {
        
        public static Wallet Wallet = new Wallet("Wallet", "Money Storage", 100);

    }
}
