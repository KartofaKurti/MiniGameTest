﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class PlayerStats 
    {
        public int MonstersKilled = 0;
        public int GoldColected = 3;
        public int Xp;
        public int Level = 1;


        public bool PlayerStart()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(); 
            if (keyInfo.Key == ConsoleKey.Enter) 
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
