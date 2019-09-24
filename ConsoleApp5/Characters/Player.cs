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
        }
        public string Name { get; set; }
        public int Age { get; set; }


        public int Damage { get; set; } = 1;

        public int Health { get; set; } = 20;

        public Inventory MyInventory { get; set; } = new Inventory();

       

    }
}
