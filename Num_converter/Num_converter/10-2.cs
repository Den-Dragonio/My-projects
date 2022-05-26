using System;

namespace Num_converter
{
    class ConverterTwo : ConverterEight
    {

        static public int DlinMass2(int a) // a - число яке вводиться на конвертацію
        {
            int d = 0; // перший ліміт
            int e = 2; // другий ліміт
            int n = 1; // розмір масиву
            int k = 1; //резервний розмір (попередній)
            bool b = true; // для циклу

            while (b == true)
            {
                if (a == d || a < e) //перевірка 1 якщо а = 0 або 2
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

        public static void Num_Converter2()
        {
            Console.WriteLine("Число яке бажаєте перевести у двійкову систему: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 2;
            int c = a;

            int[] arr = new int[DlinMass2(a)];
            int swap;
            for (int i = 0; i < arr.Length; i++)
            {
                swap = c % b;
                arr[i] = swap;
                c = c / b;
            }

            for (int i = arr.Length - 1; i >= 0; --i)
                Console.Write(arr[i] + " ");

            Console.ReadLine();
        }
    }
}
