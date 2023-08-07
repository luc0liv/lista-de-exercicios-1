//Escrever um programa que preencha um vetor de 100 elementos com valores inteiros aleatórios, e 
//iden0fique o maior e o menor número gerados, e respec0vas posições.

using System;

namespace exercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
            }

            int largest = numbers[0];
            int smallest = numbers[0];
            int largestIndex = 0;
            int smallestIndex = 0;

            for (int i = 0;i < numbers.Length; i++)
            {
                Console.WriteLine(i + ": " + numbers[i]);
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                    largestIndex = i;
                }
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                    Console.WriteLine(smallest);
                    smallestIndex = i;
                }
            }
            Console.WriteLine($"O maior número é: {largest} na posição: {largestIndex}");
            Console.WriteLine($"O menor número é: {smallest} na posição: {smallestIndex}");

            Console.ReadLine();
        }
    }
}