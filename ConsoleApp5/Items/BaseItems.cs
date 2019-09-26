using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Items
{
    public abstract class BaseItems
    {
        public BaseItems(string Name, string Description, int Value) 
        {
            this.Name = Name;
            this.Description = Description;
            this._basePrice = Value;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        private int _basePrice;
        public int BasePrice 
        {
            get { return this._basePrice; }
            set { this._basePrice = value; }
        }

        
        
    }
}
