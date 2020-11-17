using System;

namespace Aula09_Estrutura_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int note = 0;
            string result = "";
            
            Console.Write("Valor da Nota: ");
            note = int.Parse(Console.ReadLine());

            if (note >= 60)
            {
                if (note >=90)
                {
                    result = "Aprovado com louvor";
                    Console.Write("Sua nota é:{0, 10}", note);
                    Console.Write("Resultado :{0, 10}", result);
                }else 
                {
                    result = "Aprovado";
                    Console.Write("Sua nota é:{0, 10}", note);
                    Console.Write("Resultado :{0, 10}", result);
                }
            } else
            {
                if (note >= 40)
                {
                    result = "Recuperação";
                    Console.Write("Sua nota é:{0, 10}", note);
                    Console.Write("Resultado :{0, 10}", result);
                }else 
                {
                    result = "Reprovado";
                    Console.Write("Sua nota é:{0, 10}", note);
                    Console.Write("Resultado :{0, 10}", result);
                }
            }
        }
    }
}
