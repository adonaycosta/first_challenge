using System; 

class Program
{
    static void Main()
    {
        Saudacoes();
    }

    static void Saudacoes()
    {
        Console.WriteLine("Nome Usuario: ");
        var nome = Console.ReadLine();

        Console.WriteLine($"Olá {nome}, Seja muito bem vindo!!");
    }
}