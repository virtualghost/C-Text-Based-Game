using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Enemies;
using TextGame.StoryParts;

namespace TextGame.Technicalities
{
    public class Input
    {
        public enum Levels
        {
            Introduction = 1,
            FirstDay = 2
        } // for a better debug system later


        public static ConsoleKeyInfo input = Console.ReadKey(true);
        public static Boolean KeyBinds()
        {
            if(Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                return false;
            }
            return true;
        }

        public static void Debug()
        {
            /* DebugKey switch
            {
                Levels.Introduction => new StoryLauncher.Introduction(),
                Levels.FirstDay     => new StoryLauncher
            }; */ ///switch cannot return a method

            if (Console.ReadKey(true).Key == ConsoleKey.D1)
                StoryLauncher.Introduction();
            if (Console.ReadKey(true).Key == ConsoleKey.D2)
                StoryLauncher.FirstDay();
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

