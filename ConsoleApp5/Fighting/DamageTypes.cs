using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Fighting
{
    public class DamageTypes
    {
        public DamageTypes(ushort PhysicalDamage, ushort ShadowDamage, ushort LightDamage)
        {
            this.PhysicalDamage = PhysicalDamage;
            this.ShadowDamage = ShadowDamage;
            this.LightDamage = LightDamage;
        }

        public ushort PhysicalDamage { get; set; }
        public ushort ShadowDamage { get; set; }
        public ushort LightDamage { get; set; }
    }
}
