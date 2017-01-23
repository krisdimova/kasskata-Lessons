using System;

namespace _04.IOConsole
{
    class IOConsole
    {
        // \n = new line
        // \t = tab

        static void Main()
        {
            Console.WriteLine("{0:c}");
            var str = Console.ReadLine();

            for (int i = 0; i < 20000; i++)
            {
                char temp = (char)i;

                if (char.IsSymbol(temp) == true)
                {
                    continue;
                }
                else
                {
                    Console.Write("{0} : {1} ||", (char)i, i);
                }
            }
        }
    }
}
