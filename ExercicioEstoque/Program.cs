using System;

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
                ShowProductData(product);

                bool isOn = true;
                while (isOn)
                {
                    int option = ShowMenu();

                    switch (option)
                    {
                        case 1:
                            UpdateInventory(product, true);
                            break;
                        case 2:
                            UpdateInventory(product, false);
                            break;
                        case 0:
                            isOn = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }

                    ShowProductData(product);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void ShowProductData(Product product)
        {
            Console.WriteLine($"Nome: {product.name}, Preço: {product.price}, Quantidade em estoque: {product.quantity}");
            Console.WriteLine($"Valor total em estoque: {product.ValorTotalEmEstoque()}");
        }

        static int ShowMenu()
        {
            Console.WriteLine("Deseja adicionar ou remover produtos?");
            Console.WriteLine($"1 - Adicionar");
            Console.WriteLine($"2 - Remover");
            Console.WriteLine($"0 - Sair");

            if (int.TryParse(Console.ReadLine(), out int option) && option >= 0 && option <= 2)
                return option;
            return -1; 
        }

        static void UpdateInventory(Product product, bool isSum)
        {
            Console.WriteLine($"Digite a quantidade a {(isSum ? "adicionar" : "remover")}");
            if (int.TryParse(Console.ReadLine(), out int quant))
            {
                if (isSum)
                    product.AdicionarAoEstoque(quant);
                else
                    product.RemoverDoEstoque(quant);
            }
            else
            {
                Console.WriteLine("Quantidade inválida.");
            }
        }
    }
}
