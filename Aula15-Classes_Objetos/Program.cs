using System;

public class Players
{
    public int energy = 1;
    public bool alive = true;
}

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            Players player = new Players();

            Console.WriteLine("Energia: {0, 10:p}", player.energy);
        }
    }
}
