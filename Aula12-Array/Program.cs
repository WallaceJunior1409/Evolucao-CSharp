using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];
            int[] vector3 = new int[3];
            int[,] matriz = new int[2,3]{{12,13, 14},{15,16,17}};

            Random random = new Random();
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = random.Next(50);
            }

            Console.Clear();
            Console.WriteLine("Elementos do vetor 1:");
            foreach (var item in vector1)
            {
                Console.WriteLine(item);
            }

            // public static int BinarySearch(array, valor)
            Console.WriteLine("BinarySearch :");
            int number = 33;
            int position = Array.BinarySearch(vector1, number);
            Console.WriteLine("O valor {0} entá na posição {1}.", number, position);
            Console.WriteLine("----------------------------------");

            // public static void Copy(Ar_origem, Ar_destino, Qtde_elem)
            Console.WriteLine("Copy :");
            Array.Copy(vector1,vector2, vector1.Length);
            foreach (var item in vector2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");

            // public void CopyTo(Ar_destino, a_partir_pos)
            Console.WriteLine("CopyTo :");
            vector1.CopyTo(vector3, 0);
            foreach (var item in vector3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");

            // public long GetLongLength(dimensão)
            Console.WriteLine("GetLongLength :");
            long qtdeElementsVector1 = vector1.GetLongLength(0);
            Console.WriteLine("Quantidade de  elementos {0}", qtdeElementsVector1);
            Console.WriteLine("----------------------------------");

            // public int GetLowerBound(dimensão)
            Console.WriteLine("GetLowerBound :");
            int smallerVector1Index = vector1.GetLowerBound(0);
            int smallerMatrizIndex = matriz.GetLowerBound(1);
            Console.WriteLine("O menor indice do vetor1 é {0}", smallerVector1Index);
            Console.WriteLine("O menor indice da matriz é {0}", smallerMatrizIndex);
            Console.WriteLine("----------------------------------");

            // public int GetUpperBound(dimensão)
            Console.WriteLine("GetLowerBound :");
            int largestVector1Index = vector1.GetUpperBound(0);
            int largestMatrizIndex = matriz.GetUpperBound(1);
            Console.WriteLine("O maior indice do vetor1 é {0}", largestVector1Index);
            Console.WriteLine("O maior indice da matriz é {0}", largestMatrizIndex);
            Console.WriteLine("----------------------------------");

            // public object GetValue(long índice)
            Console.WriteLine("GetValue :");
            int value0 = Convert.ToInt16(vector1.GetValue(1));
            int value2 = Convert.ToInt16(matriz.GetValue(0,2));
            Console.WriteLine("O valor da posição 2 do vetor 1 é {0}", value0);
            Console.WriteLine("----------------------------------");

            // public static int IndexOf(array, valor) - retorna a primeira posicao q contem o 1
            Console.WriteLine("IndexOf :");
            int index1 = Array.IndexOf(vector1, 1);
            Console.WriteLine("Indice : {0}", index1);
            Console.WriteLine("----------------------------------");

            // public static int LastIndexOf(array, valor) - retorna a ultima posicao q contem o 1
            Console.WriteLine("IndexOf :");
            int index2 = Array.LastIndexOf(vector1, 1);
            Console.WriteLine("Indice : {0}", index1);
            Console.WriteLine("----------------------------------");

            // public static void Reverse(array)
            Array.Reverse(vector1);
            foreach (var item in vector1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");

            //public void SetValue(object valor, long pos)
            vector2.SetValue(99,0);
            for (int i = 0; i < vector2.Length; i++)
            {
                vector2.SetValue(0, 1);
            }
            Console.WriteLine("Vector2 :");
            foreach (var item in vector2)
            {
                Console.WriteLine(item);
            }

            // public void SetValue(object valor, long pos);
            vector2.SetValue(99,0);
            for (int i = 0; i < vector2.Length; i++)
            {
                vector2.SetValue(0, 1);
            }
            foreach (var item in vector2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");

            // public static void Sort(array)
            Array.Sort(vector2);
            Console.WriteLine("Sort :");
            foreach (var item in vector2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
