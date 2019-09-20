namespace TextGame.Items
{
    /// <summary>
    /// The players wallet where all the dosh is stored.
    /// </summary>
    public class WalletItem : BaseItem
    {
        public WalletItem(int money)
        {
            // A wallet is small, so we set its size to 1
            Size = 1;
            Name = "Wallet";
            Value = 1;
        }
    }
}
