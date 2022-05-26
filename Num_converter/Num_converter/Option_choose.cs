using System;
using System.Collections.Generic;
using System.Text;

namespace Num_converter
{
    class Option_choose : ConverterTwo
    {
        public static void Main()
        {
            Console.WriteLine($"Перевести з десяткової у двійкову систему числення - натисніть {"10-2"}!");;
            Console.WriteLine($"Перевести з десяткової у вісімкову систему числення - натисніть {"10-8"}!");
            Console.WriteLine($"Перевести з десяткової у шістнадцяткову систему числення - натисніть {"10-16"}!");
            string str = Console.ReadLine();
            if (str == "10-2")
            {
                Num_Converter2();
            } else if (str == "10-8")
            {
                Num_Converter8();
            } else if (str == "10-16")
            {
                Num_Converter16();
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Ви ввели неправильне значення!");
                Console.ResetColor();
                Main();
            }
        }
    }
}
