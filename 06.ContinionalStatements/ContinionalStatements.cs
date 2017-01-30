namespace _06.ContinionalStatements
{
    using System;

    class ContinionalStatements
    {
        static void Main()
        {
            int cardsCount = ParseFromConsole();
            string resultToWrite = SwitchDemo(cardsCount);
            Console.WriteLine(resultToWrite);
        }

        static int ParseFromConsole()
        {
            string stringFromConsole = Console.ReadLine();
            int numberForReturn = int.Parse(stringFromConsole);
            return numberForReturn;
        }

        static string SwitchDemo(int cc)
        {
            switch (cc)
            {
                case 1:
                    return "2";
                case 2:
                    return "3";
                case 3:
                    return "4";
                case 4:
                    return "5";
                case 5:
                    return "6";
                case 6:
                    return "7";
                case 7:
                    return "8";
                case 8:
                    return "9";
                case 9:
                    return "10";
                case 10:
                    return "J";
                case 11:
                    return "D";
                case 12:
                    return "K";
                case 13:
                    return "A";
                default:
                    return "Mainata ti";
            }
        }
    }
}
