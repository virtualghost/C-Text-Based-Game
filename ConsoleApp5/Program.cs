using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Input.KeyBinds())
            {
                Console.WriteLine("The Warp - Alpha");
                Console.WriteLine("Welcome to The Warp. You wake up one day and reality seems more distorted with each day that passes.");
                Console.WriteLine("Type in your character's name: ");
                string CharacterName = Console.ReadLine();
                while (GeneralChecker.NameChecker(CharacterName))
                {
                    Errors.NameContainsNumbers();
                    Console.WriteLine("Type in character's name: ");
                    CharacterName = Console.ReadLine();
                }
                Console.WriteLine("Type in your character's age: ");
                int CharacterAge = Convert.ToInt32(Console.ReadLine());
                while (GeneralChecker.AgeChecker(CharacterAge))
                {
                    Errors.AgeIsTooOld();
                    Console.WriteLine("Type in your character's age: ");
                    
                }
                Console.WriteLine("Greetings, " + CharacterName);
                Console.WriteLine("Press any key to continue, ESC ends the game.");
                
                Console.ReadKey();

            }
        }
    }

}
