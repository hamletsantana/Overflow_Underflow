using System;

namespace Underflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma(250,50);

            Console.ReadKey();
        }

        static byte Suma(byte num1, byte num2)
        {
            byte suma = (byte)(num1 + num2);
            Console.WriteLine(suma);

            if (num2 > byte.MaxValue - num1)
            {
                Console.WriteLine("Esto es Un Overflow");
            }
            else if (num2 < byte.MinValue - num1)
            {
                Console.WriteLine("Esto es un Underflow");
            }
            return suma;
        }

        static byte Resta(byte num1, byte num2)
        {
            if ((byte)(num1 - num2) > byte.MaxValue)
            {
                Console.WriteLine("Overflow");
            }
            if ((byte)(num1 - num2) < byte.MinValue )
            {
                Console.WriteLine("Underflow");
            }
            Console.WriteLine((byte)(num1 - num2));
            return (byte) (num1 - num2);  
        }

    }
}


