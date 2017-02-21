using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.LINQ
{
    public class Linq
    {
        // You will be given two integer lists on the first two lines(space-separated). 
        // Remove the elements in the first list from the elements in the second list.
        // If an element from the first list occurs more than once in the second list, remove all occurrences.
        // After you remove the elements, check the sum of both lists.
        // If the sum of both of them is equal, print “Yes.Sum: {sum}”. 
        // If not print the absolute difference between the two lists in the format “No.Diff: {sum}”.

        //1 2 3 4 5
        //5 3 2 7 4 1 8

        public static void Main()
        {
            List<int> first = ParseCollectionInt();
            List<int> second = ParseCollectionInt();

            var secondCollection = second.Except(first);
            List<int> firstDestincted = first.Distinct().ToList();
            Console.WriteLine(
                first.Distinct().Sum() == second.Except(first.Distinct()).Sum() ?
                "Yes. Sum: " + second.Except(first.Distinct()).Sum() :
                "No. Diff: " + Math.Abs(
                    first.Distinct().Sum() - second.Except(first).Sum()
                )
            );

            //Console.WriteLine(string.Join(", ", second));

            int maxCount = first.Count >= second.Count ?
                first.Count :
                second.Count;

            //Console.WriteLine(maxCount);

            first.AddRange(new int[maxCount - first.Count]);
            second.AddRange(new int[maxCount - second.Count]);

            //Console.WriteLine(maxCount - first.Count);
            //Console.WriteLine(maxCount - second.Count);

            //Console.WriteLine(string.Join(", ", first));
            //Console.WriteLine(string.Join(", ", second));
            List<int> sameNumbers = new List<int>();

            for (int i = 0; i < first.Count; i++)
            {
                for (int j = 0; j < second.Count; j++)
                {
                    if (first[i] == second[j] && sameNumbers.Any(x => x == first[i]) == false)
                    {
                        sameNumbers.Add(first[i]);
                    }
                }
            }

            //Console.WriteLine(string.Join(", ", first));
            //Console.WriteLine(string.Join(", ", second));
            //Console.WriteLine();
            //Console.WriteLine(string.Join(", ", sameNumbers));

            for (int i = 0; i < first.Count; i++)
            {
                if (sameNumbers.Contains(first[i]))
                {
                    first[i] = 0;
                }

                if (sameNumbers.Contains(second[i]))
                {
                    second[i] = 0;
                }
            }

            //Console.WriteLine(string.Join(", ", first));
            //Console.WriteLine(string.Join(", ", second));

            int firstSum = first.Sum();
            int secondSum = second.Sum();

            //Console.WriteLine(firstSum);
            //Console.WriteLine(secondSum);

            //if (firstSum == secondSum)
            //{
            //    Console.WriteLine("Yes.Sum: {0}.", firstSum);
            //}
            //else
            //{
            //    Console.WriteLine("No. Diff: {0}", Math.Abs(firstSum - secondSum));
            //}
        }

        private static List<int> ParseCollectionInt()
        {
            return Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToList();
        }
    }
}
