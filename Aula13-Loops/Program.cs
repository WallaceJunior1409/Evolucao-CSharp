using System;

namespace Aula13_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string[] name = new string[3];
            int[] age = new int[3];
            string password = "123";
            string passUser;

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                passUser = Console.ReadLine();

            } while (password != passUser);

            for (i = 0; i < name.Length; i++)
            {
                Console.Write("Nome : ");
                name[i] = Console.ReadLine();

                Console.Write("Idade: ");
                age[i] = int.Parse(Console.ReadLine());
            }

            /*
            j=0;
            while (j < name.Length)
            {
                Console.WriteLine("Nome : {0, 10}", name[j]);
                Console.WriteLine("Idade: {0, 10}", age[j]);

                j++;
            }
            */

            foreach (string item in name)
            {
                Console.WriteLine("Nome : {0}", item);
                foreach (var itemAge in age)
                {
                    Console.WriteLine("Idade: {0}", itemAge);
                }
            }
        }
    }
}
