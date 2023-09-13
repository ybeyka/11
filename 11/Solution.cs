namespace QuadraticEquationSolver
{
    public class Solution
    {
        public double? Root1 { get; }
        public double? Root2 { get; }
        public string Message { get; }

        public Solution(double root1, double root2, string message)
        {
            Root1 = root1;
            Root2 = root2;
            Message = message + $" Корни: {root1} и {root2}";
        }

        public Solution(double root1, string message)
        {
            Root1 = root1;
            Message = message + $" Корень: {root1}";
        }

        public Solution(string message)
        {
            Message = message;
        }
    }
}
