//Leia um valor inteiro N. Este valor será a quan0dade de valores inteiros X que serão lidos em seguida. 
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo,
//mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para 
//fora do intervalo)

using System;

namespace exercicioSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos valores serão lidos?");
            bool valuesParse = int.TryParse(Console.ReadLine(), out int values);
            int inValues = 0;
            int outValues = 0;

            if (!valuesParse) {
                Console.WriteLine("Valor inválido");
            } else {

            for (int i = 0; i < values; i++)
            {
                Console.WriteLine("Digite um número");
                bool valueXParse = int.TryParse(Console.ReadLine(), out int valueX);

                if (!valueXParse)
                {
                    Console.WriteLine("Valor inválido");
                } else
                {
                    if (valueX >= 10 && valueX <= 20)
                    {
                        inValues += 1;
                    } else
                    {
                        outValues += 1;
                    }
                }
            }

            Console.WriteLine($"{inValues} in");
            Console.WriteLine($"{outValues} out");
        }
    }
    }
}