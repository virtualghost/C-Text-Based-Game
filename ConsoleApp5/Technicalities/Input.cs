﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Enemies;

namespace TextGame.Technicalities
{
    public class Input
    {
        public static ConsoleKeyInfo input = Console.ReadKey(true);
        public static Boolean KeyBinds()
        {
            if(Console.ReadKey(true).Key == ConsoleKey.Escape)
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
