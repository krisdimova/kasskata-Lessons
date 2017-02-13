namespace _11.ArrayLongSequence
{
    // Напишете програма, която намира максимална редица от последова­телни еднакви елементи в масив. 
    // Пример: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}.
    class ArrayLongSequence
    {
        static void Main()
        {
            int[] arr = new[]
            {
              //0  1  2  3  4  5  6  7  8  9
                2, 1, 1, 2, 3, 3, 3, 3, 3, 3
            };

            int counter = 0;
            int maxSequence = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    if (counter == 0)
                    {
                        counter = 2;
                    }
                    else
                    {
                        counter++;
                    }
                }
                else
                {
                    counter = 0;
                }

                if (maxSequence < counter)
                {
                    maxSequence = counter;
                }
            }

            System.Console.WriteLine(maxSequence);
        }
    }
}
