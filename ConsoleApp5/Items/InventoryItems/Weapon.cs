using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Items.InventoryItems
{
    public class Weapon : BaseItems
    {
        private int _damage;
        public int Damage { get => this._damage; set => this._damage = value; }

        public Weapon(string Name, string Description, int Value)
            : base(Name, Description, Value)
        {

        }


    }
}
