using System;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, number2, resultOfTheDivision, rest;
            
            Console.Write("Digite o valor 1: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            show(number, number2);

            doubleValue(ref number);
            Console.WriteLine("Valor dobrado: {0}", number);

            resultOfTheDivision = dividedValue(number, number2, out rest);
            Console.WriteLine("{0} / {1} = {2} e sobra {3}", number, number2, resultOfTheDivision, rest);

            some(5, 5, 5);
        }
        static void show(int num, int num2)
        {
            Console.WriteLine("Este é um método");
            int result = num + num2;

            Console.WriteLine("Result: {0}", result);
        }
        static void doubleValue(ref int values)
        {
            values *= 2;
        }
        static int dividedValue(int dividend, int divisor, out int rest)
        {
            int quotient = 0;

            quotient = dividend/divisor;
            rest = dividend%divisor;

            return quotient;
        }
        static void some(params int[]n)
        {
            int result = 0;

            if (n.Length < 1)
            {
                Console.WriteLine("Não existe valores a serem somados.");
            } else if (n.Length < 2)
            {
                Console.WriteLine("Valores insuficientes: {0}", n[0]);
            } else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    result += n[1];
                }
                Console.WriteLine("Soma dos parametros: {0}", result);
            }
        }
    }
}
