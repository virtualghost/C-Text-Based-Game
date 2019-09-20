using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Dictionary<int, string> Items { get; set; }

        public float Damage { get; set; }

        public float Health { get; set; }

        public Player(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.Items = new Dictionary<int, string>();
            this.Damage = 0;
            this.Health = 20;

        }

    }
}
