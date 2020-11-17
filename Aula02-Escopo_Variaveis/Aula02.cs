using System;

class Aula02
{
    //variavel global -> Pode ser acessada em todos os metodos 
    static int number = 10;
    static string name = "Wallace";

    static void test()
    {
        //variavel local -> Pode ser acessada somente no metodo "test"
        int multiple = number * 10;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Numero: " + multiple);
    }

    static void Main(string[] args)
    {
        test();
    }
}