using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;

            Console.Write("Nome.....: ");
            name  = Console.ReadLine();
            
            Console.Write("Idade....: ");
            //age = Convert.ToInt32(Console.ReadLine());
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome.....:{0, 10}", name);
            Console.WriteLine("Idade....:{0,10}", age);
        }
    }
}
