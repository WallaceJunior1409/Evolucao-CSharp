using System;

namespace Aula07
{
    class Program
    {
        enum DaysOfTheWeek{Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sábado};
        static void Main(string[] args)
        {
            DaysOfTheWeek day1 = DaysOfTheWeek.Domingo;
            Console.WriteLine(day1);

            DaysOfTheWeek day2 = (DaysOfTheWeek)4;
            Console.WriteLine(day2);

            int position = (int) DaysOfTheWeek.Sexta;
            Console.WriteLine(position);
        }
    }
}
