using System;
using System.Collections.Generic;
using System.Text;

namespace Num_converter
{
    class COnverterSixteen
    {
        static public int DlinMass16(int a) // a - число яке вводиться на конвертацію
        {
            int d = 0; // перший ліміт
            int e = 16; // другий ліміт
            int n = 1; // розмір масиву
            int k = 1; //резервний розмір (попередній)
            bool b = true; // для циклу

            while (b == true)
            {
                if (a == d || a < e) //перевірка 1 якщо а = 0 або 16
                {
                    n = k; // розмір масиву не збільшується
                    b = false; //зупинка циклу
                }
                else
                {
                    d = e; // підвищення першого ліміту 
                    e = e + e; // підвищення другого ліміту
                    k = k + 1; // збільшення розміру масиву
                }
            }
            return n;
        }

        public static void Num_Converter16()
        {
            Console.WriteLine("Число яке бажаєте перевести у шістнадцяткову систему: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 16;
            int c = a;

            int[] arr = new int[DlinMass16(a)];
            int swap;
            for (int i = 0; i < arr.Length; i++)
            {
                swap = c % b;
                if (swap == 10)
                {
                    swap = 'A';
                }
                if (swap == 11)
                {
                    swap = 'B';
                }
                if (swap == 12)
                {
                    swap = 'C';
                }
                if (swap == 13)
                {
                    swap = 'D';
                }
                if (swap == 14)
                {
                    swap = 'E';
                }
                if (swap == 15)
                {
                    swap = 'F';
                }
                arr[i] = swap;
                c = c / b;
            }

            for (int i = arr.Length - 1; i >= 0; --i)
                Console.Write(arr[i] + " ");

            Console.ReadLine();
        }
    }
}
