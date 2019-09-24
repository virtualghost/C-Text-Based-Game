using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Enemies;
using TextGame.Characters;
using TextGame.Technicalities;

namespace TextGame.Fighting
{
    class Fight
    {
        static readonly Random RandomDamage = new Random();

        public static void Instructions()
        {
            Console.WriteLine("The battle system works in turns. As it stands, the first turn is yours, then your enemy's. It's very boring at the moment, later it will have Damage types and overhauls. When your turn comes, the following commands are valid:\n" +
                "physical, this leads to a physical attack, \n" +
                "shadow, this leads to a shadow attack (not yet implemented), \n" +
                "light, this leads to a light attack (not yet implemented)");
        }

        public static Boolean OneVersusOne(Player player, Enemy enemy)
        {
            Console.WriteLine("Your character's attributes are: Health {0}, Damage {1}", player.Health, player.Damage);
            Console.WriteLine("Your enemy's attributes are: Health {0}, Damage {1}", enemy.Health, enemy.Damage);       //The attributes of both adversaries
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("It's your turn. Type a command valid in this context to attack.");
                /*ConsoleKey ConsoleKeyVariable = new ConsoleKey();
                ConsoleKeyVariable = (ConsoleKey)Console.ReadKey(); 
                Input.FightingInputs(ConsoleKeyVariable, enemy); */
                var input = Console.ReadKey(true);
                Input.FightingInputs(input.Key, enemy);
                Console.WriteLine();
                int ShowEnemyHealthDamage = enemy.Health;
                switch (Console.ReadLine())
                { 
                    case "physical":
                    enemy.Health -= player.Damage + RandomDamage.Next(0, player.Damage);
                    Console.WriteLine("You have dealt {0} Physical Damage to the adversary", (ShowEnemyHealthDamage - enemy.Health));
                    break;

                    case "shadow":
                    enemy.Health -= player.Damage + RandomDamage.Next(0, player.Damage);
                    Console.WriteLine("You have dealt {0} Shadow Damage to the adversary", (ShowEnemyHealthDamage - enemy.Health));
                    break;

                    case "light":
                    enemy.Health -= player.Damage + RandomDamage.Next(0, player.Damage);
                    Console.WriteLine("You have dealt {0} Light Damage to the adversary", (ShowEnemyHealthDamage - enemy.Health));
                    break;

                }
                float ShowPlayerHealthDamage = player.Health;
                player.Health -= enemy.Damage + RandomDamage.Next(0, enemy.Damage);
                Console.WriteLine("The enemy {0} has dealt {1} Physical Damage to you.", enemy.Type, (ShowPlayerHealthDamage - player.Health));
                Console.WriteLine("The player has :{0} Health and the enemy has: {1} Health", player.Health, enemy.Health);
            }
            if(player.Health == 0)
            {
                Console.WriteLine("You died. Game over.");
                return false;
            }
            Console.WriteLine("You won. ");
            return true; 
        } 

    }
}
