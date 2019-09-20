using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class Errors
    {
        public static string NameContainsNumbersError = "Error: Your character's name contains numbers.";
        public static string AgeIsTooOldError = "Error: Your character's age exceeds 100";
        public static void NameContainsNumbers()
        {
            Console.WriteLine(NameContainsNumbersError);
        }
        public static void AgeIsTooOld()
        {
            Console.WriteLine(AgeIsTooOldError);
        }
    }
}
