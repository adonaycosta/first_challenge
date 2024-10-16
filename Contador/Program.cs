using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {

        Console.WriteLine("Digite seu texto: ");
        string texto = Console.ReadLine();
        
        string TextoSemEspaco = texto.Replace(" ", "");
        Console.WriteLine($"Quantidade de caracter: {TextoSemEspaco.Length}");
    }
}