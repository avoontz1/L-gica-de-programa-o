using System;

namespace Logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm;
            int valorDois:

            //aqui vai o codigo
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("----------------------");
            Console.Write("Dígite o primeiro valor: ")
            int valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ")
            int valorDois = int.Parse(Console.ReadLine());

            //Processamento
            int soma = valorUm + valorDois;

            //Exibir
            Console.WriteLine("A Soma de "+valorUm+" + "+valorDois+" = "+soma);
            

        }
    }
}
