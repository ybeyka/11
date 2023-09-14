namespace QuadraticEquationSolver
{
    public static class Solver
    {
        public static Solution Solve(Task task)
        {
            double a = task.A;
            double b = task.B;
            double c = task.C;

            double discriminant = CalcDiscriminant(a, b, c);
            double root1, root2;

            if (discriminant > 0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new Solution(root1, root2, "У уравнения два корня.");
            }

            if (discriminant == 0)
            {
                root1 = -b / (2 * a);
                return new Solution(root1, "У уравнения один корень.");
            }

            return new Solution("У уравнения нет вещественных корней.");
        }

        private static double CalcDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}





