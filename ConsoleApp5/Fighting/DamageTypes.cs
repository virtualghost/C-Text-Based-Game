using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Fighting
{
    public class DamageTypes
    {
        public DamageTypes(int PhysicalDamage, int ShadowDamage, int LightDamage)
        {
            this.PhysicalDamage = PhysicalDamage;
            this.ShadowDamage = ShadowDamage;
            this.LightDamage = LightDamage;
        }

        public int PhysicalDamage { get; set; }
        public int ShadowDamage { get; set; }
        public int LightDamage { get; set; }
    }
}
