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
        public static BaseItems Wallet = new BaseItems("Wallet", "Money Storage", 20);

    }
}
