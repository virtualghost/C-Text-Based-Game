using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Items;

namespace TextGame.Items.InventoryItems
{
    public class Wallet : BaseItems
    {
        private int _amount;
        public int Amount { get => _amount; set => _amount = value; }

        public Wallet(string Name, string Description, int Value)
            : base(Name, Description, Value)
        {

        }
        public int DeductValue(int Value)
        {
            this._amount -= Value;
            return this._amount;
        }
    }
}
