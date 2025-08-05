using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public static class Helper
    {
        public static int GetIntFromUserUsingTryParse(string dataName)
        {
            int number = 0;
            do
            {
                Console.Write($"Please Enter {dataName}: ");
            }
            while (!int.TryParse(Console.ReadLine(), out number));
            return number;
        }
        
        public static int GetIntFromUser(string massageToUser, bool isMainMsg = true)
        {
            int number = 0;
            switch (isMainMsg)
            {
                case true:
                    do
                    {
                        Console.Write(massageToUser);
                    }
                    while (!int.TryParse(Console.ReadLine(), out number));
                    break;
                case false:
                    do
                    {
                        Console.Write($"Please Enter the {massageToUser}: ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out number));
                    break;
            }

            return number;
        }
        public static decimal GetDecimalFromUser(string massageToUser, bool isMainMsg = true)
        {
            decimal number = 0;
            switch (isMainMsg)
            {
                case true:
                    do
                    {
                        Console.Write(massageToUser);
                    }
                    while (!decimal.TryParse(Console.ReadLine(), out number));
                    break;
                case false:
                    do
                    {
                        Console.WriteLine($"Please Enter the {massageToUser}: ");
                    }
                    while (!decimal.TryParse(Console.ReadLine(), out number));
                    break;
            }

            return number;
        }
        public static string GetStringFromUser(string dataName)
        {
            string str = string.Empty;
            do
            {
                Console.Write($"Please Enter the {dataName}: ");
                str = Console.ReadLine() ?? string.Empty;
            }
            while (str == string.Empty || int.TryParse(str, out _));

            return str;
        }
        public static char GetCharFromUser(string msg, bool isMainMsg = false)
        {
            char character = default(char);
            bool isParsed = false;
            if (isMainMsg)
            {
                do
                {
                    Console.Write(msg);
                    isParsed = char.TryParse(Console.ReadLine(), out character);
                }
                while (!(isParsed && !int.TryParse(character.ToString(), out _)));
            }
            else
            {
                do
                {
                    Console.Write($"Please Enter the {msg}: ");
                    isParsed = char.TryParse(Console.ReadLine(), out character);
                }
                while (!(isParsed && !int.TryParse(character.ToString(), out _)));
            }

            return character;
        }
    }
}
