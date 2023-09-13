using System;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение квадратных уравнений вида ax^2 + bx + c = 0");


            Console.WriteLine("Пожалуйста, введите значение коэффициента 'a':");
            double a = GetCoefficient();

            Console.WriteLine("Пожалуйста, введите значение коэффициента 'b':");
            double b = GetCoefficient();

            Console.WriteLine("Пожалуйста, введите значение коэффициента 'c':");
            double c = GetCoefficient();

            Console.WriteLine($"Введено уравнение: {a}x^2 + ({b})x + ({c}) = 0");

            Task task = new Task(a, b, c);
            Solution solution = Solver.Solve(task);

            Console.WriteLine(solution.Message);
        }

        static double GetCoefficient()
        {
            double coefficient;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out coefficient))
                {
                    return coefficient;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите численное значение.");
                }
            }
        }
    }
}

