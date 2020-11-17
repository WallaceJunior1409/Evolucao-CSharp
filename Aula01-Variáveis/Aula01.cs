using System;

class Aula01
{
    static void Main(string[] args) 
    {
        byte age = 17;
        int number = 0;
        char letter = 'W';
        float point = 5.3f;
        string name = args[0];
        bool result = true;

        var aux = 10;
        const string profession = "Programmer";

        Console.WriteLine("Nome: " + name);
        Console.WriteLine("Idade: " + age);
        Console.WriteLine("Iniciais: " + letter);
        Console.WriteLine("Resultado: " + result);
    }
}