using System;

namespace exercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            //A jornada de trabalho semanal de um funcionário é de 40 horas.O funcionário que trabalhar mais de 40
            //horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50 %.Escreva um
            //algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do
            //funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas(considere que o mês
            //possua 4 semanas exatas).

            Console.WriteLine("Digite a quantidade de horas trabalhadas");
            bool hoursParse = decimal.TryParse(Console.ReadLine(), out decimal hoursWorked);
            Console.WriteLine("Digite seu salário por hora");
            bool salaryParse = decimal.TryParse(Console.ReadLine(),out decimal salary);

            int regularHours = 40 * 4;
            double totalSalary = 0;

            if (hoursWorked <= regularHours)
            {
                totalSalary = hoursWorked * salary;
            }
            else
            {
                decimal extraHours = hoursWorked - regularHours;
                decimal extraSalary = extraHours * (salary * 1.5);
                decimal baseSalary = regularHours * salary;
                totalSalary = baseSalary + extraSalary;

            }

            Console.WriteLine($"Salário total: {totalSalary}");
        }
    }
}
