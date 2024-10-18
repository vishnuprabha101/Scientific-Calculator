using Calculator.Interfaces;

namespace Calculator.Services
{
    public class CalculatorService : ICalculatorService<int>
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;
       

        public double SquareRoot(double a)
        {
            if (a < 0) throw new ArgumentOutOfRangeException("Cannot calculate square root of a negative number.");
            return Math.Sqrt(a);
        }

        public double Power(double baseValue, double exponent) => Math.Pow(baseValue, exponent);

    }   
    
}
