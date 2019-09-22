using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Characters;
using TextGame.Items;
using TextGame.Technicalities;
using TextGame.StoryParts;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Input.KeyBinds())
            {
                StoryLauncher.Introduction();
                StoryLauncher.FirstDay();
                Console.ReadKey();
            }
        }
    }

}
