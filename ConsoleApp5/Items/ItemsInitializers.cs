using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Items;

namespace TextGame.Items
{
    static class ItemsInitializers
    {
        public static BaseItem soso = new WalletItem("Wallet", "Money Storage", 1);
        public static BaseItem Wallet = new WalletItem("Wallet", "Money Storage", 1);

    }
}
