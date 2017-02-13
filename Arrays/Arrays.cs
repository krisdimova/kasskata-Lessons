using System;

namespace Arrays
{
    class Arrays
    {
        static int index = 0;
        static int[] arr;

        static void Main()
        {
            arr = new int[6];

            arr[0] = 6;
            arr[1] = 5;
            arr[2] = 10;
            arr[3] = 8;
            arr[4] = 12;
            arr[5] = 2;

            RecursiveWriteLine(index);
        }

        private static void RecursiveWriteLine(int index)
        {
            if (index < arr.Length)
            {
                Console.WriteLine(arr[index++]);
                RecursiveWriteLine(index);
            }
        }
    }
}
