using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ARRAY
            */
            int[] id = new int[3];//0 - 4
            id[0] = 10; id[1] = 11; id[2] = 12;

            string[] name = new string[3]{"Wallace", "Wellington", "Vitoria"};

            double[] salary = {1990.90, 1200.00, 1500.80};

            //Console.WriteLine("Id:{0,10}\nNome:{1,10}\nSalario:{2,10:c }", id[0], name[0], salary[0]);
            //Console.WriteLine("Id:{0,10}\nNome:{1,10}\nSalario:{2,10:c}", id[1], name[1], salary[1]);
            //Console.WriteLine("Id:{0,10}\nNome:{1,10}\nSalario:{2,10:c}", id[2], name[2], salary[2]);
        
            /*
                MATRIZ
            */
            int[,] number = new int[2,2];
            int[,] number2 = new int[2,2]{{11, 12}, {13, 14}};

            number[0,0] = 1; number[0,1] = 2;
            number[1,0] = 3; number[1,1] = 4;

            Console.WriteLine(number2[1,1]);
        }
    }
}
