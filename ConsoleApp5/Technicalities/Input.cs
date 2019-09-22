using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Enemies;

namespace TextGame.Technicalities
{
    public class Input
    {
        public static Boolean KeyBinds()
        {
            if(Console.ReadKey().Key == ConsoleKey.Escape)
            {
                return false;
            }
            return true;
        }

        public static void FightingInputs(ConsoleKey ConsoleKey, Enemy enemy)
        {

            switch (ConsoleKey)
            {
                case ConsoleKey.D:
                    Console.WriteLine(enemy.Description);
                    break;
                default:
                    break;
                    
            }

        }
    }
}

