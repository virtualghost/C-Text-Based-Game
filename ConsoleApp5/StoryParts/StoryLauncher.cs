using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Characters;
using TextGame.Items;
using TextGame.Technicalities;
using TextGame.Fighting;
using TextGame.Enemies;

namespace TextGame.StoryParts
{
    class StoryLauncher
    {
        static Player player;
        public static void Introduction()
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
                uint CharacterAge = Convert.ToUInt32(Console.ReadLine());
                while (GeneralChecker.AgeChecker(CharacterAge))
                {
                    Errors.AgeIsTooOld();
                    Console.WriteLine("Type in your character's age: ");
                    CharacterAge = Convert.ToUInt32(Console.ReadLine());
                }
                Console.WriteLine("Greetings, " + CharacterName);
                player = new Player(CharacterName, CharacterAge);
                Console.WriteLine("Press any key to continue, ESC ends the game.");
                Console.WriteLine("Enemies are more susceptible to different types of attacks. Damage can be of differing types, such as Physical, Shadow or Light. To see a description of the current enemy, press D");
                
        }
        public static void FirstDay()
        {
            Console.WriteLine("First day. You wake up at 5AM and get ready for work. You take a shower, get dressed, grab your wallet, and get out of the apartment. On the way to the subway station, you come across a {0}. He asks you for some cigarettes, you don't smoke so you have nothing to give him. He instead asks for some money. What do you do?", EnemyInitializers.burglar.Type);
            player.MyInventory.AddItem("Wallet", ItemsInitializers.Wallet);
            if (Console.ReadLine() != "give him money")
            {
                Fight.Instructions();
                Console.WriteLine("He pulls a knife and aims it at you. You're in a fight!");
                Fight.OneVersusOne(player, EnemyInitializers.burglar);
                
            }
            
        }
    }
}
