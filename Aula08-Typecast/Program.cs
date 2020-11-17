using System;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão implicita - segura
            int number1 = 10;
            long result = number1;
            Console.WriteLine(result);

            // Conversão explicita - não segura -> typecast
            float number2 = 12.5f;
            int result2 = (int)number2;
            Console.WriteLine(result2); 
        }
    }
}
