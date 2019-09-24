using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Items
{
    class BaseItems
    {
        public BaseItems(string Name, string Description, int Value) 
        {
            this.Name = Name;
            this.Description = Description;
            this.Value = Value;
        }

        public BaseItems(int Value)
        {
            this.Value = value;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<int, string> Type { get; set; } = new Dictionary<int, string>();
        public float Damage { get; set; }
        private int Value { get; set; }
        public int value //NAMING RULE VIOLATION
        {
            get { return this.Value; }
            set { this.Value = value; } //ENCAPSULATION
        }

        
        public int DeductValue(int value)
        {
            this.Value -= value;
            return this.Value;
        }
    }
}
