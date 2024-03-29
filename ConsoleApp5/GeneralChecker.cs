﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class GeneralChecker
    {
        public static char[] numbers = "1234567890".ToCharArray();
        
        public static Boolean NameChecker(string CharacterName)
        {
            return CharacterName.IndexOfAny(numbers) >= 0;
        }
        public static Boolean AgeChecker(uint CharacterAge)
        {
            return CharacterAge > 100;
        }
    }
}
