namespace TextGame.Items
{
    /// <summary>
    /// This is the base class for every item. All items need to derive from this and when working with items, this is the class to use.
    /// </summary>
    public class BaseItem
    {
        /// <summary>
        /// How much space does the item occupy in storage
        /// </summary>
        public int Size;

        /// <summary>
        /// What type of item are we talking about. 
        /// </summary>        
        //public ItemType Type; //ItemType could be an Enum containing different options

        /// <summary>
        /// The name of the item
        /// </summary>
        public string Name;

        /// <summary>
        /// The base value of the item. Could be used to adjust buy/sell prices according to standing and the likes.
        /// </summary>
        public int Value;

        /// <summary>
        /// Is this item only allowed once per inventory?
        /// </summary>
        public bool Unique;
    }
}
