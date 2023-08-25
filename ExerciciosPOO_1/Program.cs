namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.cor = "Azul";
            retangulo.lado1 = 3.5;
            retangulo.lado2 = 2;
            Console.WriteLine(Teste.DetalhesFigura(retangulo)); //"Cor da figura: Azul - Área da figura: 7"
            Console.ReadLine();
        }
    }
}