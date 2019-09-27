using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Items;
using TextGame.Fighting;

namespace TextGame.Characters
{
    class Player
    {
        public Player(string Name, uint Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.Damage = new DamageTypes(1, 0, 0);
        }
        public string Name { get; set; }
        public uint Age { get; set; }


        public DamageTypes Damage { get; set; }

        public int Health { get; set; } = 20;

        public List<BaseItems> Inventory { get; set; } = new List<BaseItems>();




    }
}
