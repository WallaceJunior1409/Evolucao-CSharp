using System;

namespace Aula04
{
    class Program
    {
        static void store()
        {
            double purchaseValue = 5.50;
            double valueSale;
            double profit = 0.1;
            string product = "Hamburgão";

            valueSale = purchaseValue + (purchaseValue * profit);

            Console.WriteLine("Produto......:{0, 15}", product);
            Console.WriteLine("Val.Compra...:{0, 15:c}", purchaseValue);
            Console.WriteLine("Lucro........:{0,15:p}", profit);
            Console.WriteLine("Val.Venda....:{0, 15:c}", valueSale);
        }
        static void Main(string[] args)
        {
            int number1, number2, result;
            number1= 10; 
            number2 = 2; 
            result = number1 * number2;

            //Saida -> Indices -> muitas variaveis a ser impresa num write
            //Console.Write("Numero1={0}, Numero2={1}, Resultado={2}", number1, number2,result);

            //Saida -> Indices + caracteres de escape (\n = enter, \t = tab)
            //Console.Write("Numero1=\t{0},\nNumero2=\t{1},\nResultado=\t{2}", number1, number2,result);
            store();
        }
    }
}
