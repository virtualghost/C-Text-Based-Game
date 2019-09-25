namespace TextGame.Items
{
    public class WalletItem : BaseItem
    {
        private int _amount;

        /// <summary>
        /// Wallet amount
        /// </summary>
        public int Amount { get => _amount; set => _amount = value; }

        public WalletItem(string name, string description, int value)
            : base(name, description, value)
        {

        }

        public int DeductAmount(int amount)
        {
            _amount -= amount;
            return Amount;
        }
    }
}
