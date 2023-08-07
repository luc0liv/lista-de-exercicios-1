using System;
using System.Collections.Generic;
using System.Drawing;

namespace exercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Um imposto é calculado com base na seguinte tabela:
            //            Até 1.200,00 isento
            //            de 1.201,00 a 2.500,00 10 %
            //            de 2.501,00 a 5.000,00 15 %
            //            acima de 5.000,00 20 %.
            //Implemente um programa que leia o valor base e calcule o imposto a pagar

            Console.WriteLine("Digite seu salário");
            bool salaryParse = double.TryParse(Console.ReadLine(), out double salary);

            if (salaryParse)
            {
                if (salary > 5000)
                {
                    Console.WriteLine($"O imposto será de 20%. Imposto a pagar: R${calculatePercentage(salary, 20)}");
                }
                else if (salary >= 1201 && salary <= 2500)
                {
                    Console.WriteLine($"O imposto será de 10%. Imposto a pagar: R${calculatePercentage(salary, 10)}");
                }
                else if (salary >= 2501 && salary <= 5000)
                {
                   Console.WriteLine($"O imposto será de 15%. Imposto a pagar: R${calculatePercentage(salary, 15)}");
                }
                else
                {
                    Console.WriteLine("Você está isento de impostos.");
                }

                Console.ReadLine();
            } 
            else 
            {
                Console.WriteLine("Valor inválido!");
                Console.ReadKey();
            }
        }

        static double calculatePercentage(double value, int percent)
        {
            return (value * percent) / 100;
        }
    }
}