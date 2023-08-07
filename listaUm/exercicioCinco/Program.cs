//Um Posto de combus>veis deseja determinar qual de seus produtos tem a preferência de seus clientes.
//Escreva um algoritmo para ler o 0po de combus>vel abastecido (codificado da seguinte forma: 1.Álcool
//2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser 
//solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o 
//número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quan0dade de clientes que abasteceram 
//cada 0po de combus>vel, conforme exemplo.

using System;

namespace exercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;
            int totalCustomers = 0;

            while(proceed)
            {
                Console.WriteLine("Digite o número que corresponde ao seu combustível favorito");
                Console.WriteLine("1 - Álcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Sair");

                bool optionParse = int.TryParse(Console.ReadLine(), out int option);
                if (!optionParse || option < 1 || option > 4) {
                    Console.WriteLine("Opção inválida");
                    continue;
                }
                else
                {
                    switch(option)
                    {
                        case 1:
                            alcohol += 1;
                            break;
                        case 2:
                            gasoline += 1;
                            break;
                         case 3:
                            diesel += 1; 
                            break;
                        default:
                            proceed = false;
                            Console.WriteLine("MUITO OBRIGADO!");
                            break;
                    }
                }
            }

            Console.WriteLine($"Total álcool: {alcohol}");
            Console.WriteLine($"Total gasolina: {gasoline}");
            Console.WriteLine($"Total diesel: {diesel}");
            totalCustomers = alcohol + gasoline + diesel;
            Console.WriteLine($"Total de pessoas que abasteceram: {totalCustomers}");
            Console.ReadKey();
        }
    }
}
