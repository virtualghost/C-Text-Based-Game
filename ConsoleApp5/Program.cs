using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Characters;
using TextGame.Items;
using TextGame.Technicalities;
using TextGame.StoryParts;
using TextGame.Items.CrystalTheory;

namespace TextGame
{
    class Program
    {
        static void Main()
        {
            /*Stat Amount = new Stat();
            Stat MaxDamage = new Stat();
            Stat MinDamage = new Stat();
            BaseItem Wallet = new BaseItem();
            BaseItem Frostmourne = new BaseItem();
            BaseItemStat WalletAmount = new BaseItemStat();
            WalletAmount.MinValue = 0;
            WalletAmount.MaxValue = 5000;
            Wallet.BaseItemStatList.Add(WalletAmount);
            Amount.BaseItemStat.Add(WalletAmount);
            Amount.Name = "amount";
            WalletAmount.AStat = Amount; */ /// usage of a database-thought type of item system
             while (Input.KeyBinds())
            {
                StoryLauncher.Introduction();
                StoryLauncher.FirstDay();
                Console.ReadKey(true); 
            } 
        }
    }

}
