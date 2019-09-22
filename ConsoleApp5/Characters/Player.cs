using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Items;

namespace TextGame.Characters
{
    class Player
    {
        public Player(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.Damage = 0;
            this.Health = 20;
        }
        public string Name { get; set; }
        public int Age { get; set; }


        public float Damage { get; set; } = 1;

        public float Health { get; set; } = 20;

        public Inventory MyInventory { get; set; } = new Inventory();

       

    }
}
