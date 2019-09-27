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
using TextGame.Items.InventoryItems;

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
            Console.WriteLine("First day. You wake up at 5AM and get ready for work. You take a shower, get dressed, grab your wallet, and get out of the apartment. On the way to the metro station, you come across a {0}. He asks you for some cigarettes, you don't smoke so you have nothing to give him. He instead asks for some money. What do you do?", EnemyInitializers.burglar.Type);
            player.MyInventory.AddItem("Wallet", ItemsInitializers.WalletItem);
            if (player.MyInventory.Dictionary["Wallet"].TypeOfObject() == BaseItems.ObjectType.WalletType)
            {
                player.MyInventory.Dictionary["Wallet"] = (Wallet)player.MyInventory.Dictionary["Wallet"];
            }
            if (Console.ReadLine() != "give him money")
            {
                Fight.Instructions();
                Console.WriteLine("He pulls a knife and aims it at you. You're in a fight!");
                Fight.OneVersusOne(player, EnemyInitializers.burglar);
            }
            else player.MyInventory.Dictionary["Wallet"].DeductValue(100);
            
            Console.WriteLine("Your wallet now has {0} dollars left.", player.MyInventory.Dictionary["Wallet"].Amount);
            
            if (player.MyInventory.Dictionary.TryGetValue("Wallet", out List<BaseItems> value))
            {

                Console.WriteLine($"For key = \"tif\", value = {ItemsInitializers.WalletItem.Amount}.");
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }
                                      
            Console.WriteLine("Shocked from the experience, you rush to enter the metro. It is crowded, but fairly safe save for thieves. After a few stations and a bit of walking, you find yourself at work. \n" +
                "You sit down at your desk and boot up your PC, however a feeling in the back of your minid lingers that everything is not as it seems.");
        }
    }
}
