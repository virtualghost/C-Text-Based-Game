using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Damage
    {
        public Dictionary<string, string> PhysicalAttacks;
        public Dictionary<string, string> ChaosAttacks;
        public Dictionary<string, string> LightAttacks;
        public Damage()
        {
            this.PhysicalAttacks= new Dictionary<string, string>();
            this.ChaosAttacks = new Dictionary<string, string>();
            this.LightAttacks = new Dictionary<string, string>();
            this.PhysicalAttacks.Add("FA", "FistAttack");
            this.PhysicalAttacks.Add("KA", "KnifeAttack");
            this.PhysicalAttacks.Add("PA", "PistolAttack");
            this.ChaosAttacks.Add("CB", "ChaosBolt");
            this.ChaosAttacks.Add("CC", "ChaosCurse");
            //this.ChaosAttacks.Add("", "ShadowPanic");
            //this.LightAttacks.Add("", "");
            //this.LightAttacks.Add("", "");
            //this.LightAttacks.Add("", "");
            //this.SpellBook.Add("A1")
        }
    }
}
