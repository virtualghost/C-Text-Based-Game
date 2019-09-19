using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
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
    }
}
