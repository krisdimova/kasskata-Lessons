using System;

namespace ArrayExcersices
{
    class ArrayProblem
    {
        // Да се напише програма, която създава масив с 20 елемента от целочислен тип и инициализира всеки от 
        // елементите със стойност равна на индекса на елемента умножен по 5. Елементите на масива да се изведат на конзолата.

        static void Main()
        {
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
