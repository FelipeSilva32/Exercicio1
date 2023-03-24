using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1) if(numero <=9)            {
                Console.WriteLine("O Numero está dentro da faixa permitida ");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
