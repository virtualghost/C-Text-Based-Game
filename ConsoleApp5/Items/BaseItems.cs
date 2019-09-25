using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Items
{
    public abstract class BaseItem
    {
        public BaseItem(string name, string description, int basePrice) 
        {
            this.Name = name;
            this.Description = description;
            this._basePrice = basePrice;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<int, string> Type { get; set; } = new Dictionary<int, string>();
        private int _basePrice { get; set; }
        public int BasePrice //NAMING RULE VIOLATION
        {
            get { return this._basePrice; }
            set { this._basePrice = value; } //ENCAPSULATION
        }
    }
}
