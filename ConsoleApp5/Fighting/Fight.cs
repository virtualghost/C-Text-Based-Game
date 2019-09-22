using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Enemies;
using TextGame.Characters;

namespace TextGame.Fighting
{
    class Fight
    {
        public static void OneVersusOne(Player player, Enemy enemy)
        {
            Console.WriteLine("Your character's attributes are: Health {0}, Damage {1}", player.Health, player.Damage);
            Console.WriteLine("Your enemy's attributes are: Health {0}, Damage {1}", enemy.Health, enemy.Damage);
        } 

    }
}
