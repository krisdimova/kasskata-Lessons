namespace _12.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Lists
    {
        static void Main()
        {
            // Масив, който се уразмерява на ръка. 
            int[] arrSmall = new int[5];
            var a = arrSmall.ToList();

            //arrSmall[0] = 1;
            //arrSmall[1] = 2;
            //arrSmall[2] = 3;
            //arrSmall[3] = 4;
            //arrSmall[4] = 5;

            //Console.WriteLine(string.Join(", ", arrSmall));

            //int[] arrBig = ArrBig(arrSmall);
            //arrBig[5] = 6;

            //Console.WriteLine(string.Join(", ", arrBig));
            // Масив, който се уразмерява на ръка.




            // Лист : Автоматично оразмеряващ се масив.
            List<string> list = new List<string>();
            list.Add("Pesho"); // 0
            list.Add("Gosho"); // 1
            list.Add("Peppi"); // 2
            list.Add("pepsi"); // 3
            list.Add("Stamat"); //

            list.Remove("Pepi");
            //list.RemoveAt(5);

            // Маха всички по предикат - ламбда функция
            list.RemoveAll(e => e.StartsWith("P"));

            // Добавя цяла нова колекция отзад на колекцията
            list.AddRange(new[] { "Tosho", "Mimi", "Kolio" });

            // Търси по елемент и връща индекса му. Ако няма съвпадения връща  - нещо
            int binarySearch = list.BinarySearch("Stamatсд");
            //Console.WriteLine(binarySearch);

            //// Маха всички елементи.
            //list.Clear();

            List<string> result = list.FindAll(e => e == "Mimi");
            //Console.WriteLine(result);

            // Сортира
            //list.Sort();

            // Обръща
            //list.Reverse();

            list.TrueForAll(e => e == "Pesho" && e != "Gosho");
            // 

            Console.WriteLine(string.Join(", ", list));

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

        }

        private static int[] ArrBig(int[] arrSmall)
        {
            int[] arrBig = new int[arrSmall.Length + 1];

            for (int i = 0; i < arrSmall.Length; i++)
            {
                arrBig[i] = arrSmall[i];
            }

            return arrBig;
        }
    }
}
