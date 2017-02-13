namespace _07.Loops
{
    using System;

    class Loops
    {
        static void Main()
        {
            FindMinNumber(); // 01
            //RepeatString();  // 02
            //NthDigit();      // 03

            //int i = 0;
            //for (; i < 12;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int j = 0;
            //while (j < 12)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 12);

            //foreach (int @char in "Pesho")
            //{
            //    Console.Write((char)(@char + 9) + " ");
            //}

            //Console.WriteLine();
        }

        private static void NthDigit()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            //FindNthDigit(number, index);
            Console.WriteLine(FindNthDigit(number, index));
        }

        static int FindNthDigit(long number, int index)
        {
            for (int i = 1; i < index; i++)
            {
                number /= 10;
            }

            return (int)number % 10;
        }

        static void RepeatString()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            var strO = RepeatString(RepeatString(RepeatString(str, count), count), count);
            Console.WriteLine("{0} {1}", strO, strO.Length);
        }

        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 1; i <= count; i++)
            {
                repeatedString += str;
            }

            return repeatedString;
        }

        private static void FindMinNumber()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());

            int minNumber = GetMin(a, b);
            minNumber = GetMin(c, minNumber);
            minNumber = GetMin(d, minNumber);
            minNumber = GetMin(e, minNumber);
            minNumber = GetMin(f, minNumber);
            minNumber = GetMin(g, minNumber);
            minNumber = GetMin(h, minNumber);
            minNumber = GetMin(i, minNumber);

            Console.WriteLine(minNumber);
        }

        private static int GetMin(int first, int second)
        {
            if (first < second)
            {
                return first;
            }
            else if (second < first)
            {
                return second;
            }
            else
            {
                return second;
            }
        }

        //     
        static void GetMinNumber(int first, int second) // 0 или повече Параметри/Аргументи
        {
        }
    }
}
