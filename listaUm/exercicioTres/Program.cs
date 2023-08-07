using System;

namespace exercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para ler: quan0dade atual em estoque, quan0dade máxima em estoque e quan0dade
            //mínima em estoque de um produto.Calcular e escrever a quan0dade média((quan0dade média =
            //quan0dade máxima +quan0dade mínima)/ 2). Se a quan0dade em estoque for maior ou igual a quan0dade
            //média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'.

            Console.WriteLine("Digite a quantidade atual no estoque");
            bool currentQuantityParse = int.TryParse(Console.ReadLine(), out int currentQuantity);
            Console.WriteLine("Digite a quantidade máxima do produto");
            bool maxQuantityParse = int.TryParse(Console.ReadLine(), out int maxQuantity);
            Console.WriteLine("Digite a quantidade mínima do produto");
            bool minQuantityParse = int.TryParse(Console.ReadLine(), out int minQuantity);

            int mediumQuantity = (maxQuantity + minQuantity) / 2;
            Console.WriteLine($"Quantidade média: {mediumQuantity}");

            if (currentQuantity >= mediumQuantity)
            {
                Console.WriteLine("Não efetuar compra");
            }
            else
            {
                Console.WriteLine("Efetuar compra");
            }
        }
    }
}
