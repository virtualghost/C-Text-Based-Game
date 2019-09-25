namespace TextGame.Items
{
    public class WeaponItem : BaseItem
    {
        private float _damage;

        public float Damage { get => _damage; set => _damage = value; }

        public WeaponItem(string name, string description, int value)
            : base(name, description, value)
        {

        }
    }
}
