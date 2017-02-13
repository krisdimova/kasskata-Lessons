namespace _10.ArrayCheck
{
    using System;

    // Да се напише програма, която чете два масива от конзолата и прове­рява дали са еднакви
    // числата в индексите, дължината

    class ArrayCheck
    {
        static void Main(string[] args)
        {
            int length;
            bool isEqual = true;

            Console.Write("Type first array length: ");
            length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];
            Console.WriteLine("First array.");
            FillArray(length, arr1);

            Console.Write("Type second array length: ");
            length = int.Parse(Console.ReadLine());
            int[] arr2 = new int[length];
            Console.WriteLine("Second array.");
            FillArray(length, arr2);

            //Console.WriteLine(Enumerable.SequenceEqual(arr1, arr2));

            isEqual = CheckArraysEquals(arr1, arr2);

            if (isEqual == true)
            {
                Console.WriteLine("is Equal");
            }
            else
            {
                Console.WriteLine("is NOT Equal");
            }
        }

        private static bool CheckArraysEquals(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void FillArray(int length, int[] array)
        {
            int i;
            for (i = 0; i < length; i++)
            {
                Console.Write(i + " place: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
