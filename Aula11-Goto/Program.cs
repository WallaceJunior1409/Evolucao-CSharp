using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            char pizza, option;
            double price;
            int time;

            //Label start
            start:
            Console.Clear();

            Console.WriteLine("----- Seja Bem Vindo -----");
            Console.WriteLine("Escolha o sabor da pizza :");
            Console.WriteLine("(c) Calabreza ");
            Console.WriteLine("(q) 4 Queijos ");
            Console.WriteLine("(e) Estrogonofe ");

            pizza = char.Parse(Console.ReadLine());

            switch (pizza)
            {
                case 'c':
                case 'C':
                    price = 32.90;
                    time = 45;
                    Console.WriteLine("-> O valor da pizza é : {0:c}", price);
                    Console.WriteLine("-> O tempo de preparo é : {0} minutos.", time);
                break;
                case 'q':
                case 'Q':
                    price = 34.00;
                    time = 40;
                    Console.WriteLine("-> O valor da pizza é : {0:c}", price);
                    Console.WriteLine("-> O tempo de preparo é : {0} minutos.", time);
                break;
                case 'e':
                case 'E':
                    price = 35.00;
                    time = 50;
                    Console.WriteLine("-> O valor da pizza é : {0:c}", price);
                    Console.WriteLine("-> O tempo de preparo é : {0} minutos.", time);
                break;
                default:
                    Console.WriteLine("-> Nenhum valor selecionado!");
                break;
            }

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Fazer outro pedido?[s/n] ");
            option = char.Parse(Console.ReadLine());

            if (option == 's' || option == 'S')
            {
                goto start;
            } else
            {
                Console.Clear();
                Console.WriteLine("Pedido realizado");
            }
        }
    }
}
