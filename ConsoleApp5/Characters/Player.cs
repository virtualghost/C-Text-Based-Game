using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Items;

namespace TextGame.Characters
{
    /// <summary>
    /// This is the player, we could make a base character class which contains stuff that all characters have...
    /// </summary>
    class Player
    {
        private string _name;
        private int _age;
        private List<BaseItem> _items;
        private float _damage;
        private float _health;

        /// <summary>
        /// What's the players name.
        /// </summary>
        public string Name { get => _name; }

        /// <summary>
        /// How old is the player.
        /// </summary>
        public int Age { get => _age; }

        /// <summary>
        /// What items is the player holding.
        /// </summary>
        public List<BaseItem> Items { get => _items; }

        /// <summary>
        /// How much damage the player can do.
        /// </summary>
        public float Damage { get => _damage; }

        /// <summary>
        /// Current health of the player.
        /// </summary>
        public float Health { get => _health; }

        public Player(string name, int age)
        {
            this._name = name;
            this._age = age;
            this._items = new List<BaseItem>();
            this._damage = 0;
            this._health = 20;
        }

        /// <summary>
        /// Add an Item to the players inventory.
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(BaseItem item)
        {
            // could have some checks if it is an item that can only be added once and it that case either replace or reject the adding, check the BaseItem class on how ;)
            _items.Add(item);
        }

        /// <summary>
        /// Add multiple items to the players inventory.
        /// </summary>
        /// <param name="items"></param>
        public void AddItems(IEnumerable<BaseItem> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }
    }
}
