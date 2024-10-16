using System;
using System.ComponentModel.Design;
using System.Numerics;

class Program
{
    static void Main()
    {

        Console.WriteLine("Digite a placa.");
        string entrada = Console.ReadLine();
        string placa = entrada.ToUpper();


        bool placaValida = Verificador(placa);


        if (placaValida)
        {
            Console.WriteLine($"A Placa {placa} é válida");
        }
        else
        {
            Console.WriteLine($"A Placa {placa} é invalida.");
        }

       
    }

    static bool Verificador(string placa)
    {
        if(placa.Length != 7)
        {
            return false;
        }

        for(int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
            {
                return false;
            }
        }

        for(int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
            {
                return false;
            }
        }

        return true;
    }

}

   
