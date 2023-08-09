//Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque).
//Em seguida:
//• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
//• Realizar uma entrada no estoque e mostrar novamente os dados do produto
//• Realizar uma saída no estoque e mostrar novamente os dados do produto.

using System;
using System.Runtime.InteropServices;

namespace ExercicioEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o nome do produto");
                string name = Console.ReadLine() ?? "";
                Console.WriteLine("Digite o preço do produto");
                bool priceParse = double.TryParse(Console.ReadLine(), out double price);
                Console.WriteLine("Digite a quantidade do produto");
                bool quantityParse = int.TryParse(Console.ReadLine(), out int quantity);

                Product product = new(name, price, quantity);
                Console.WriteLine($"Nome: {product.name}, Preço: {product.price}, Quantidade em estoque: {product.quantity}");
                Console.WriteLine($"Valor total em estoque: {product.ValorTotalEmEstoque()}");

                Console.WriteLine("Deseja adicionar ou remover produtos?");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Remover");
                bool optionParse = int.TryParse(Console.ReadLine(), out int option);

                Console.WriteLine($"Digite a quantidade que deseja {(option == 1 ? "adicionar" : "remover") }");
                bool quantParse = int.TryParse(Console.ReadLine(), out int quant);
                if (option == 1 ) {
                    product.AdicionarAoEstoque(quant);
                }
                else
                {
                    product.RemoverDoEstoque(quant);
                }

                Console.WriteLine($"Nome: {product.name}, Preço: {product.price}, Quantidade em estoque: {product.quantity}");
                Console.WriteLine($"Valor total em estoque: {product.ValorTotalEmEstoque()}");

            } catch (Exception error) 
            {
                Console.WriteLine(error.Message);
            } 
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
