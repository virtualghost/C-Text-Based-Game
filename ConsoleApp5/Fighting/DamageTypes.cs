using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Fighting
{
    public class DamageTypes
    {
        public DamageTypes(short PhysicalDamage, short ShadowDamage, short LightDamage)
        {
            this.PhysicalDamage = PhysicalDamage;
            this.ShadowDamage = ShadowDamage;
            this.LightDamage = LightDamage;
        }

        public short PhysicalDamage { get; set; }
        public short ShadowDamage { get; set; }
        public short LightDamage { get; set; }
    }
}
