namespace _03.Operators
{
    using System;

    class Operators
    {
        static void Main()
        {
            int a = 1;
            a++;        // a = a + 1;
            a--;       //a = a - 1;


            a += 69; // ->> a = a + 69;
            a -= 69; // ->> a = a - 69;
            a *= 69; // ->> a = a * 69;
            a %= 69; // ->> a = a % 69; modul
            a /= 69; // ->> a = a / 69;

            a = 1;
            string azSymNull, result;

            azSymNull = null;
            result = azSymNull ?? "Gosho";
            Console.WriteLine(result);

            azSymNull = "Pesho";
            result = azSymNull ?? "Gosho";
            Console.WriteLine(result);

              a =    a < 2   ?  a+2 :  a-2;
            //a = EXPRESSION ? TRUE : FALSE;
            //       bool    
            //               ?  true
            //                       : false

            if (a < 2)
            {
                a = a + 2;
            }
            else
            {
                a = a - 2;
            }

            Console.WriteLine(2 + "_Misisipi"); //Concatination 

            Console.WriteLine('T' + 'Y'); // cw 84 + 89 ot ASCII таблцата
            //Console.WriteLine(true == false);

            // == , != 
            // <= , >=
            //bool @bool = 3 >= 5;
            ////Console.WriteLine(@bool);

            //@bool = true && false;
            //Console.WriteLine("T && F  => " + @bool);

            //@bool = true && true;
            //Console.WriteLine("T && T  => " + @bool);

            //@bool = false && false;
            //Console.WriteLine("F && F  => " + @bool);

            //@bool = true || false;
            //Console.WriteLine("T || F  => " + @bool);

            //@bool = true || true;
            //Console.WriteLine("T || T  => " + @bool);

            //@bool = false || false;
            //Console.WriteLine("F || F  => " + @bool);

            //string str = "bira";
            //Console.WriteLine("Value =" + str + "!");
            //str = "";
            //Console.WriteLine("Value =" + str + "!");
            //string str = null; // null != 0 
            //Console.WriteLine("Value =" + str + "!");
            //string s = "abcdefg";
            //Console.WriteLine(s[2]);
            //Console.WriteLine(5 / (float)2);
            //Console.WriteLine(14 / (float)7); //3
            //Console.WriteLine(21 % 7); //3
        }
    }
}
