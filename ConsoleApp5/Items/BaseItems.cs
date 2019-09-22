using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Player_Classes
{
    class BaseItems
    {
        public BaseItems(string Name, string Description) 
        {
            this.Name = Name;
            this.Description = Description;
            this.Value = 0;
        }

        
        
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<int, string> Type { get; set; } = new Dictionary<int, string>();
        public float Amount { get; set; }
        public float Damage { get; set; }

        public float Value { get; set; }
        
        
        
    }
}
