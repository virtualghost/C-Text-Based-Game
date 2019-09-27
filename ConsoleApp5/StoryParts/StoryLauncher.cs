using System;
using System.Linq;
using TextGame.Characters;
using TextGame.Enemies;
using TextGame.Fighting;
using TextGame.Items;
using TextGame.Items.InventoryItems;
using System.Text;

namespace TextGame.StoryParts
{
    class StoryLauncher
    {
        static Player player;
        public static void Introduction()
        {
            Console.WriteLine("The Warp - Alpha (Learning project, focused more on learning C# than on writing an interesting story)");
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
            player.Inventory.Add(ItemsInitializers.WalletItem);
            var wallet = player.Inventory.OfType<Wallet>().SingleOrDefault();
            /*player.MyInventory.AddItem("Wallet", ItemsInitializers.WalletItem);
            var wallet = player.MyInventory.Dictionary["Wallet"].OfType<Wallet>().SingleOrDefault();
            if (player.MyInventory.Dictionary["Wallet"][0].TypeOfObject() == BaseItems.ObjectType.WalletType) ///this code smells
            {
                player.MyInventory.Dictionary["Wallet"][0] = (Wallet)player.MyInventory.Dictionary["Wallet"][0];
            }  */

            if (Console.ReadLine() != "give him money")
            {
                Fight.Instructions();
                Console.WriteLine("He pulls a knife and aims it at you. You're in a fight!");
                Fight.OneVersusOne(player, EnemyInitializers.burglar);
            }
            else wallet.DeductValue(100);

            Console.WriteLine($"Your wallet now has {wallet.Amount} dollars left.");
            /* var value = new BaseItems();
            if (player.MyInventory.Dictionary.TryGetValue("Wallet", out value))
            {

                Console.WriteLine($"For key = \"tif\", value = {wallet.Amount}.");
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            } */

            Console.WriteLine("Shocked from the experience, you rush to enter the metro. It is crowded, but fairly safe save for thieves. After a few stations and a bit of walking, you find yourself at work. \n" +
                "You sit down at your desk and boot up your PC, however a feeling in the back of your mind lingers that everything is not as it seems.\n" +
                "After the PC finally boots up (the company is on a budget), a new email notification shows up.");
            var SuspiciousEmail = new StringBuilder(300);
            SuspiciousEmail.AppendLine("Sender: umbrellacompany@fsb.su");
            SuspiciousEmail.AppendLine("Title: The work must be done");
            SuspiciousEmail.AppendLine("Content: It's time.");
            Console.WriteLine(SuspiciousEmail.ToString());
            Console.WriteLine("What a strange email, you think. It's most likely an attempt to spread malware, but you don't care because this company does not invest in a proper IT department anyway.");
            Console.WriteLine("You quickly forget about this incident and move on to working on today's tasks.");
            Console.WriteLine("Time passes and you need to go home. Same story, same routine, it's depressing but it pays the bills.");
            Console.WriteLine("Once home, sleep comes quickly and you get to it.");
        }
        public static void SecondDay()
        {

        }
    }
}
