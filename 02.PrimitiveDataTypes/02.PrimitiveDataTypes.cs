namespace _02.PrimitiveDataTypes
{
    class PrimitiveDataTypes
    {
        static void Main()
        {
            // Целочислени.
            byte @byte = 255; // Smallest: 0 - 255 0 / 255 / когато превърти заочва от нулата

            sbyte @sbyte = -128; // Smallest with negative numbers -128 / 127

            short @shortType = -65; // Bigger data type /  16bit / + / -
            ushort @ushortType = 32767; //Bigger with only POSITIVE numbers / +

            int @integer = 2147483647; //Middle data type most use. + / - 32bit; / когато превърти започва от минус милиардите
            uint @uinteger = 4294967295;  //Middle data type most use.; + ; 32bit

            long @long = -71271263213; // Biggest / 64 bit / + / - / когато превърти започва от минус
            ulong @ulong = 3127762137123213235; // 64bit / + / когато превърти започва от 0

            // Плаваща запетая
            //                  mantisa
            float @float = 123.1234567F; // Smallest / прецизност до 7 знак/ 0,000000001 до 100000000,0 -> стойности по-големи от int/32bit/defoult - 0.0F
            //знакът f винаги се поставя след числото иначе се приема за double
            double @double = 123.12345678990123456D; // Medium / прецизност до 15-16 знак / 32bit/defoult - 0.0D
            decimal @decimal = 123124.12345678901234567890123456789012M; //Biggest / 128 bits / прецизен до 28-29 знак / default - 0.0M

            // Boolean
            bool @booleanType = true || false; // True or False

            // Текстови данни
            char @charType = (char)65535;
            char @chartype1 = 'P';

            string @string = "Pesho qde applka.";

            string[] array = @string.Split(' ');

            System.Console.WriteLine(array[0]);
            System.Console.WriteLine(array[1]);
            System.Console.WriteLine(array[2]);

            System.Console.WriteLine(string.Join("||", array));
        }
    }
}
