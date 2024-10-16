using System;

class Program
{
    static void Main()
    {
    
        double valor1 = LerEntrada("Digite um número: ");
        double valor2 = LerEntrada("Digite outro número: ");


        Console.WriteLine($"A Soma dos valores é: {Soma(valor1,valor2)}");
        Console.WriteLine($"A Subtração dos valores é: {Subtracao(valor1,valor2)}");
        Console.WriteLine($"A Divisão dos valores é: {Divisao(valor1,valor2)}");
        Console.WriteLine($"A Multiplicação dos valores é: {Multiplicacao(valor1,valor2)}");
        Console.WriteLine($"A Média dos valores é: {Media(valor1,valor2)}");


    }

    static double LerEntrada(string mensagem)
    {
        double numero;

        Console.WriteLine("Digite um número: ");
        string entrada = Console.ReadLine();

        while(!double.TryParse(entrada, out numero))
        {
            Console.WriteLine("Entrada invalida, tente novamente!");
            entrada = Console.ReadLine();
        }

        return numero;
    }

    static double Soma(double valor1, double valor2) => valor1 + valor2;
    static double Subtracao(double valor1, double valor2) => valor1 - valor2;
    static double Media(double valor1, double valor2) => (valor1 + valor2) / 2;
    static double Multiplicacao(double valor1, double valor2) => valor1 * valor2;
    static double Divisao(double valor1, double valor2)
    {
        if (valor2 == 0)
        {
            Console.WriteLine("Erro Divisão por 0");
        }

        return valor1 / valor2;

    }
}