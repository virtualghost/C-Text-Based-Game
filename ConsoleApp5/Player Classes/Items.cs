using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Player_Classes
{
    class Items
    {
        public class WalletItem
        {
            public string Wallet { get; set; }
            public float money { get; set; }

            public WalletItem(float money)
            {
                this.Wallet = "Wallet";
                this.money = money;
            }
        }
        public WalletItem wallet = new WalletItem(100);
    }
}
